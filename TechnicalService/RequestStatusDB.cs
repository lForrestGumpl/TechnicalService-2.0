using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalService
{
   public class RequestStatusDB
    {
        Dictionary<int, RequestStatus> statuses;
        Serializer<Dictionary<int, RequestStatus>> serializer;           
        int autoincrement = 1;
        string filePath;

        static RequestStatusDB instance;
        public static RequestStatusDB GetInstance()
        {
            if (instance == null)
                instance = new RequestStatusDB();
            return instance;
        }

        private RequestStatusDB()
        {
            filePath = "status.bin";
            serializer = new Serializer<Dictionary<int, RequestStatus>>(filePath);              
            statuses = serializer.Load(ref autoincrement);
        }

        public void Save()
        {
            serializer.Save(statuses, autoincrement);
        }

        public RequestStatus CreateRequestStatus(string name)
        {
            RequestStatus requestStatus = new RequestStatus(autoincrement++, name);
            statuses.Add(requestStatus.ID, requestStatus);
            return requestStatus;
        }

        public void RemoveRequestStatus(RequestStatus requestStatus)

        {
            statuses.Remove(requestStatus.ID);
        }

        public List<RequestStatus> GetRequestStatuses()
        {
            return statuses.Select(s => s.Value)?.ToList();

        }

        public RequestStatus GetRequestStatusByID(int id) =>
            statuses[id];
    }
}
