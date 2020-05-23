using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalService
{
    [Serializable]
    public class Request
    {
        public int ID { get; private set; }
        public string Name { get; private set; }
        public DateTime DateCreate { get; private set; }
        public DateTime DateClose
        {
            get => dateClose;
            set
            {
                dateClose = value;
                logger.Log(this);
            }
        }
        public int StatusID
        {
            get => statusID;
            set
            {
                statusID = value;
                logger.Log(this);
            }
        }
        public RequestPriority Priority
        {
            get => priority;
            set
            {
                priority = value;
                logger.Log(this);
            }
        }
        public int WorkerID
        {
            get => workerID;
            set
            {
                workerID = value;
                logger.Log(this);
            }
        }
        public int ClientID
        {
            get => clientID;
            set
            {
                clientID = value;
                logger.Log(this);
            }
        }

        [NonSerialized]
        RequestLogger logger;
        private DateTime dateClose;
        private int statusID;
        private RequestPriority priority;
        private int workerID;
        private int clientID;

        public Request(int id, string name,DateTime dateCreate)
            
        {
            ID = id;
            Name = name;
            logger = RequestLogger.GetInstance();
            DateCreate = dateCreate;
            logger.Log(this);
        }

        public bool Closed
        {
            get =>
        DateClose != DateTime.MinValue;
        }
    }
}
