using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalService
{
    public class Client
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public ClientStatus Status { get; set; }

        public Client(int id)
        {
            ID = id;
        }
        public Client(int id, string lastName, string firstName, ClientStatus status) : this(id)
        {
            LastName = lastName;
            FirstName = firstName;
            Status = status;
        }
    }
}
