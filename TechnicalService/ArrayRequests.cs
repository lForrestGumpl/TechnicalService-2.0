﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalService
{
   public class ArrayRequests
    {
        public List<Request> requests { get; set; }

        public ArrayRequests(List<Request> requests)
        {
            this.requests = requests;
        }

        public ArrayRequests GetRequestsByPriority
            (RequestPriority priority)
        {
            return new ArrayRequests(requests.FindAll(s => s.Priority == priority));
               
        }

        public ArrayRequests GetRequestsByStatus
            (RequestStatus status) =>
            new ArrayRequests(requests.FindAll(s => s.StatusID == status.ID));
               

        public ArrayRequests GetRequestsByWorker
            (Worker worker) =>
            new ArrayRequests(requests.FindAll(s => s.WorkerID == worker.ID));
        
        public ArrayRequests GetRequestsByClient
             (Client client) =>
             new ArrayRequests(requests.FindAll(s => s.ClientID == client.ID));

        public ArrayRequests GetRequestsCreateBetweenDate
            (DateTime start) =>
            new ArrayRequests(requests.FindAll(s => s.DateCreate >= start));

      

    
                
    }
}