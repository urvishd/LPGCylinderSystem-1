using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LPGCylinderSystem.Models
{
    public class Admin
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Admin_Id { get; set; }    
        public string Password { get; set; }
        public List<News> Newss { get; set; }
    }
}
