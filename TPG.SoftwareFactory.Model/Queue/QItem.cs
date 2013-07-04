using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace TPG.SoftwareFactory.Model.Queue
{
    [Serializable]
    public class QItem
    {
        public QItem(QType QueueTypeObject, QCommandResponse OResponse, QCommandArguements ORequest)
        {
            this.QueueTypeObject = QueueTypeObject;
            this.QueueCommandResponseObject = OResponse;
            this.QueueCommandArguementObject = ORequest;
        }

        public QType QueueTypeObject;
        public QCommandArguements QueueCommandArguementObject;
        public QCommandResponse QueueCommandResponseObject;

        public string FileName;
        public int CurrentRetryCount;
        public int MaxRetryCount = QConfigSettings.Settings.MaxRetryCount;

    }
}
