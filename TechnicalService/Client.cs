using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalService
{
    [Serializable]
    public class Client
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public ClientStatus Status { get; set; }
        public long Phone { get; set; }

        public Client(int id)
        {
            ID = id;
        }
        public Client(int id, string lastName, string firstName, long phone, ClientStatus status) : this(id)
        {
            Phone = phone;
            LastName = lastName;
            FirstName = firstName;
            Status = status;
        }
    }
}
