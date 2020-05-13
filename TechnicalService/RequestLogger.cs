using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalService
{

   public class RequestLogger
    {
        public void Log(Request request)
        {
            var db = RequestStatusDB.GetInstance();
            string statusName = null;
            if (request.StatusID == 0)
                statusName = "без статуса";
            else
                statusName = db.GetRequestStatusByID(
                    request.StatusID).Name;

            File.AppendAllText(
                Properties.Settings.Default.FilePath,
                $"{DateTime.Now}: id {request.ID} " +
                $"name {request.Name} create: {request.DateCreate}" +
                $"close: {request.DateClose != DateTime.MinValue}, status: {statusName}" +
                $"priority: {request.Priority}, worker id: {request.WorkerID}");
        }

        static RequestLogger instance;
        public static RequestLogger GetInstance()
        {
            if (instance == null)
                instance = new RequestLogger();
            return instance;
        }
    }
}
