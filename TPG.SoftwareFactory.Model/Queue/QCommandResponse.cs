using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace TPG.SoftwareFactory.Model.Queue
{
    [Serializable]
    public class QCommandResponse
    {
        public object CommandResponse;

        public string ResponseText;

        public QCommandResponse() { }

        public QCommandResponse(object commandResponse)
        {
            this.CommandResponse = commandResponse;
        }
    }
}
