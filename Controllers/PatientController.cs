using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using Newtonsoft.Json;
using EMR.Models;
using EMR.Models.Patient;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EMR.Controllers
{
    public class PatientController : Controller
    {
        public IActionResult Index() { return View(); }


        [HttpPost]
        public IActionResult Index(Patient p)
        {
            //Access the MongoDB database, using test database until Azure is set up
            var client = new MongoClient("mongodb://localhost:27017");
            string db_name = "test";
            var database = client.GetDatabase(db_name);
            var collection = database.GetCollection<BsonDocument>("patients");

            //Search for a document with the name field matching the name of the Patient passed into this controller function
            var filter = Builders<BsonDocument>.Filter.Eq("Name", p.Name.ToString());
            var document = collection.Find(filter).First();
            //"p" is empty except for a name, now we have the whole patient object pulled from the database which we call "m"
            var m = BsonSerializer.Deserialize<Patient>(document);
            //Render a new page, passing in the data from Patient m
            return View(m);
        }
    }
}
