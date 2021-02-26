using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LPGCylinderSystem.Models
{
    public class ServiceRequest
    {
        [BsonId]
        public ObjectId Service_Id { get; set; }
        public string Category { get; set; }
        public string Detail { get; set; }
        public string Status { get; set; }
        public string Remark { get; set; }

    }
}
