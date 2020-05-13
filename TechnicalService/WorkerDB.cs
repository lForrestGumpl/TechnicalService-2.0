using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalService
{
   public class WorkerDB
    {
        Dictionary<int, Worker> workers;
        Serializer<Dictionary<int, Worker>> serializer;
        string filePath;
        int autoincrement = 1;

        static WorkerDB instance;
        public static WorkerDB GetInstance()
        {
            if (instance == null)
                instance = new WorkerDB();
            return instance;
        }

        private WorkerDB()
        {
            filePath = "workers.bin";
            serializer = new Serializer<
                Dictionary<int, Worker>>(filePath);
            workers = serializer.Load(ref autoincrement);
        }

        public void Save()
        {
            serializer.Save(workers, autoincrement);
        }

        public Worker CreateWorker()
        {
            var worker = new Worker(autoincrement++);
            workers.Add(worker.ID, worker);
            return worker;
        }

        public Worker GetWorkerByID(int id)
        {
            return workers[id];
        }

        public List<Worker> GetWorkersByStatus
            (WorkerStatus workerStatus)
        {
            return workers.
                Where(s => s.Value.Status ==
                workerStatus)?.
                Select(s => s.Value).ToList();
        }

        public List<Worker> GetWorkers()
        {
            return workers.
                Select(s => s.Value)?.ToList();
        }
    }
}
