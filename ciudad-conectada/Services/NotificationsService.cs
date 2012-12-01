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
            var server = MongoServer.Create("mongodb://127.0.0.1");
            Database = server.GetDatabase("ciudadconectada");
        }

        public void AddNotification(Notification notification)
        {
            var collection = Database.GetCollection<Notification>("Notifications");
            collection.Insert(notification);
        }

        public IList<Notification> GetNotifications(Position position)
        {
            var collection = Database.GetCollection<Notification>("Notifications");
            return collection.FindAll().ToList();
        }
    }
}