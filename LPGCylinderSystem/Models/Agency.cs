using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//hju
namespace LPGCylinderSystem.Models
{
    public class Agency
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Agency_Id { get; set; }
        public string AgencyName { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string Pincode { get; set; }
        public List<DeliveryBoy> DeliveryBoys { get; set; }

    }
}
