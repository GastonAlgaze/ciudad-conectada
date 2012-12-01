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
            var connectionString = "mongo://@localhost:27017/ciudad-conectada?auto_reconnect";
            var server = MongoServer.Create(connectionString);
            Database = server.GetDatabase("ciudad-conectada");
        }

        public void AddNotification(Notification notification)
        {
            var collection = Database.GetCollection<dynamic>("Notifications");
            collection.Insert(notification);
        }
    }
}