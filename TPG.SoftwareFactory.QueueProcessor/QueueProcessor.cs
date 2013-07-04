using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TPG.SoftwareFactory.Model.Queue;
using TPG.SoftwareFactory.ComponentFactory;
using TPG.SoftwareFactory.Contract;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace TPG.SoftwareFactory.QueueProcessor
{
    public class QueueProcessor
    {
        public static int count = 0;
        public static int currentCount = 0;

        private ILogger logger = null;

        public QueueProcessor(ILogger logger)
        {
            this.logger = logger;
        }

        private object thisLock = new object();

        public QCommandResponse ReProcess(string fileName)
        {

            // Deserialize it
            QItem rebuiltItem;

            QueueEngineFactory qFactory = new QueueEngineFactory();

            IQueueEngine qEngine = qFactory.GetQueueEngine();

            rebuiltItem = qEngine.Get(typeof(QItem), fileName) as QItem;

            //Delete the Queued file once read
            QCommandResponse responseObj = new QCommandResponse();

            if (rebuiltItem.CurrentRetryCount < rebuiltItem.MaxRetryCount)
            {
                try
                {
                    //Delete the queued file once read
                    File.Delete(fileName);

                    //Reconstruct the File Save using reflection
                    AssemblyName assName = new AssemblyName(rebuiltItem.QueueTypeObject.Type.GetType().Assembly.FullName);
                    Assembly asm = Assembly.Load(assName);

                    // get type of class Calculator from just loaded assembly
                    Type objType = asm.GetType(rebuiltItem.QueueTypeObject.Type.GetType().ToString());

                    // create instance of class Calculator
                    object objInstance = rebuiltItem.QueueTypeObject.Type;

                    //// invoke public instance method: public void Clear()
                    Object obj = objType.InvokeMember(rebuiltItem.QueueTypeObject.MethodName,
                        BindingFlags.InvokeMethod | BindingFlags.Instance | BindingFlags.Public,
                        null, objInstance, rebuiltItem.QueueCommandArguementObject.QRequestArgument) as Object;

                    responseObj.CommandResponse = obj;
                    responseObj.ResponseText = QConfigSettings.Settings.ResponseText;
                    currentCount++;
                }
                catch (Exception ex)
                {
                    logger.Debug(ex, ex);
                    //Log it
                    currentCount++;
                    rebuiltItem.CurrentRetryCount += 1;
                    Guid guid = qEngine.Put(rebuiltItem);
                }
            }
            else
            {
                lock (thisLock)
                {
                    logger.Info("Moving the file as Max Retry Count Reached | File Name = " + fileName.ToString());
                    currentCount++;
                    File.Move(fileName, QConfigSettings.Settings.QFailedFileLocation + Path.GetFileName(fileName));
                }
            }

            return responseObj;

        }

        public void Init()
        {
            if (currentCount == count & currentCount == 0)
            {
                string[] files = Directory.GetFiles(QConfigSettings.Settings.QFileLocation);

                count = files.Length;

                logger.Info("Total queue items to be processed are " + DateTime.Now.ToString());

                // Parallel equivalent
                Parallel.ForEach(files, item => ReProcess(item));

                //while (currentCount < count)
                //{
                //    ReProcess(files[currentCount]);
                //}
            }
        }

        public void Process()
        {
            logger.Info("The process starts at " + DateTime.Now.ToString());
            Init();
            logger.Info("The process ends at " + DateTime.Now.ToString());
            Thread.Sleep(QConfigSettings.Settings.RetryInterval);
            currentCount = 0;
            count = 0;
        }

    }
}
