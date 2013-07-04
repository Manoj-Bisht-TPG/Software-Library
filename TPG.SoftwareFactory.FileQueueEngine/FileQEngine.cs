using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TPG.SoftwareFactory.Contract;
using System.Runtime.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using TPG.SoftwareFactory.Model.Queue;
using System.Reflection;

namespace TPG.SoftwareFactory.FileQueueEngine
{
    public class FileQEngine : IQueueEngine
    {
        public QCommandResponse Operation(Boolean IsAsyn, QType type, QCommandResponse response, params object[] arguments)
        {
            Boolean isError = false;

            QCommandResponse responseObj = new QCommandResponse();

            //Create the arguement list
            QCommandArguements qArguements = new QCommandArguements();

            qArguements.QRequestArgument = new Object[arguments.Length];

            for (int i = 0; i < arguments.Length; i++)
            {
                qArguements.QRequestArgument[i] = arguments[i];
            }

            QItem item = new QItem(type, response, qArguements);

            try
            {
                if (!IsAsyn)
                {
                    //Reconstruct the File Save using reflection
                    AssemblyName assName = new AssemblyName(item.QueueTypeObject.Type.GetType().Assembly.FullName);
                    Assembly asm = Assembly.Load(assName);

                    // get type of class Calculator from just loaded assembly
                    Type objType = asm.GetType(item.QueueTypeObject.Type.GetType().ToString());

                    // create instance of class Calculator
                    object objInstance = Activator.CreateInstance(objType);

                    //// invoke public instance method: public void Clear()
                    Object obj = objType.InvokeMember(item.QueueTypeObject.MethodName,
                        BindingFlags.InvokeMethod | BindingFlags.Instance | BindingFlags.Public,
                        null, objInstance, item.QueueCommandArguementObject.QRequestArgument) as Object;

                    responseObj.CommandResponse = obj;
                    responseObj.ResponseText = QConfigSettings.Settings.ResponseText;
                }

            }
            catch (Exception Ex)
            {
                isError = true;
            }

            if (isError = true || IsAsyn == true)
            {
                Guid fileName = Put(item);
                responseObj.CommandResponse = null;
                responseObj.ResponseText = QConfigSettings.Settings.ResponseText;
            }

            return responseObj;
        }

        public Object Get(Type ObjectType, string guid)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(guid, FileMode.Open, FileAccess.Read, FileShare.Read);

            try
            {
                Object AnObject = formatter.Deserialize(stream);
                return AnObject;
            }
            finally
            {
                stream.Close();
            }
        }

        public Guid Put(QItem p)
        {

            IFormatter formatter = new BinaryFormatter();
            Guid guid = Guid.NewGuid();
            Stream stream = new FileStream(QConfigSettings.Settings.QFileLocation + guid.ToString(), FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
            formatter.Serialize(stream, p);
            stream.Close();
            return guid;

        }
    }
}
