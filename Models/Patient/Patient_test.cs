using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using Newtonsoft.Json;


using MongoDB.Bson.Serialization;


namespace EMR.Models.Patient
{
    public class Patient_test
    {
        public ObjectId _id { get; set; }
        public string name { get; set; }
        
    }
}

