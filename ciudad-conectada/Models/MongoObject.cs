using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ciudad_conectada.Models
{
    public abstract class MongoObject
    {
        public MongoDB.Bson.ObjectId _id { get; set; }

        public MongoObject()
        {
        }

        public MongoObject(string _id)
        {
            this._id = new MongoDB.Bson.ObjectId(_id);
        }
    }
}
