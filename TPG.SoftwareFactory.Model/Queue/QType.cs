using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace TPG.SoftwareFactory.Model.Queue
{
    [Serializable]
    public class QType
    {

        public object Type = null;
        public QType(object type)
        {
            this.Type = type;
        }
        public string MethodName;

        //public string AssemblyInfo;
        //public string TypeInfo;
        //public string Location;

    }
}
