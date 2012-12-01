using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ciudad_conectada.Models;
using MongoDB.Driver;

namespace ciudad_conectada.Services
{
    public class NotificationsService
    {
        private static NotificationsService instance;

        public static NotificationsService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NotificationsService();
                }
                return instance;
            }
        }

        public MongoDatabase Database { get; set; }


        private NotificationsService()
        {
            var client = new MongoClient();
            var server = client.GetServer();
            
            Database = server.GetDatabase("ciudadconectada");
        }

        public void AddNotification(Notification notification)
        {
            var collection = Database.GetCollection<dynamic>("Notifications");
            collection.Insert(notification);
        }
    }
}