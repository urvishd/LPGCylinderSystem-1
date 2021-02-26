using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LPGCylinderSystem.Models
{
    public class News
    {
        public ObjectId News_Id { get; set; }
        public string Description { get; set; }
        public DateTime DateTime { get; set; }
    }
}
