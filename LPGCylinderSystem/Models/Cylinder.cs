using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LPGCylinderSystem.Models
{
    public class Cylinder
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Cylinder_Id { get; set; }
        public string CylinderName { get; set; }
        public string CylinderType { get; set; }
        public int Price { get; set; }


    }

}
