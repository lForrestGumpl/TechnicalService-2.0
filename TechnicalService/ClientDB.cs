using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalService
{

   public class ClientDB
    {
        Dictionary<int, Client> clients;
        Serializer<Dictionary<int, Client>> serializer;
        string filePath;
        int autoincrement = 1;

        static ClientDB instance;
        public static ClientDB GetInstance()
        {
            if (instance == null)
                instance = new ClientDB();
            return instance;
        }

        private ClientDB()
        {
            filePath = "clients.bin";
            serializer = new Serializer<
                Dictionary<int, Client>>(filePath);
            clients = serializer.Load(ref autoincrement);
        }

        public void Save()
        {
            serializer.Save(clients, autoincrement);
        }

        public Client CreateClient()
        {
            var client = new Client(autoincrement++);
            clients.Add(client.ID, client);
            return client;
        }

        static Client defaultClient;

        public Client GetClientByID(int id)
        {

            if (!clients.ContainsKey(id))
            {
                if (defaultClient == null)
                {
                    defaultClient = new Client(0);
                    defaultClient.FirstName = "Клиент не указан";
                }
                return defaultClient;
            }
            return clients[id];
        }

        public List<Client> GetClientsByStatus
            (ClientStatus clientStatus)
        {
            return clients.
                Where(s => s.Value.Status == clientStatus)?. 
                Select(s => s.Value).ToList();                        
        }

        public List<Client> GetClients()
        {
            return clients.
                Select(s => s.Value)?.ToList();
        }
        public void RemoveClient(Client client)
        {
            clients.Remove(client.ID);
        }
    }
}
