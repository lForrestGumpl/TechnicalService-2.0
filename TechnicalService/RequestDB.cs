using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalService
{
   public class RequestDB
    {
        List<Request> requests = new List<Request>();
        int autoincrement = 1;
        Serializer<List<Request>> serializer;
        string filePath;

        static RequestDB instance;
        public static RequestDB GetInstance()
        {
            if (instance == null)
                instance = new RequestDB();
            return instance;
        }

        private RequestDB()
        {
            filePath = "requests.bin";
            serializer = new Serializer<List<Request>>(filePath);
            requests = serializer.Load(ref autoincrement);
        }

        public void Save()
        {
            serializer.Save(requests, autoincrement);
        }

        public Request CreateRequest(string name, DateTime dateCreate)
        {
            var request = new
                Request(autoincrement++,
                name, dateCreate);
            requests.Add(request);
            return request;
        }

        public ArrayRequests GetRequests() =>
            new ArrayRequests(requests);

       public void RemoveRequest(Request request)
        {
            requests.Remove(request);
        }

    }
}
