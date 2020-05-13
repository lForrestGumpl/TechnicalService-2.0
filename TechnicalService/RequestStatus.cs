using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalService
{
    [Serializable]
    public class RequestStatus
    {
        public int ID { get; private set; }
        public string Name { get; private set; }
        public RequestStatus(int id, string name)
        {
            ID = id;
            Name = name;
        }
    }
}

