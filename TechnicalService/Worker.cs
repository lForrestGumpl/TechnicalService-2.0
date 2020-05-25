using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalService
{
    [Serializable]
    public class Worker
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public WorkerStatus Status { get; set; }

        public Worker(int id)
        {
            ID = id;
        }
        public Worker(int id, string lastName, string firstName, WorkerStatus status) : this(id)
        {
            LastName = lastName;
            FirstName = firstName;
            Status = status;
        }

    }
}
