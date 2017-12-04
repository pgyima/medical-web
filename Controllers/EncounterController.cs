using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EMR.Models.Patient;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;
using EMR.Models;


namespace MVC_MONGODB.Controllers
{
    public class EncounterController : Controller
    {
        // GET: ENCOUNTER
        public ActionResult Index()
        {
            return View();
        }

        // GET: ENCOUNTER/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult ViewAll()
        {
            return View();
        }

        // GET: ENCOUNTER/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Date(Patient p)
        {
            return View(p);
        }

        [HttpPost]
        public IActionResult HistoryIllness(Patient p)
        {
            return View(p);
        }

        [HttpPost]
        public IActionResult PastHistory(Patient p)
        {
            return View(p);
        }

        [HttpPost]
        public IActionResult ViewAll(Patient p)
        {
            var client = new MongoClient("mongodb://localhost:27017");
            string db_name = "test";
            var database = client.GetDatabase(db_name);
            var collection = database.GetCollection<BsonDocument>("patients");
            var filter = Builders<BsonDocument>.Filter.Eq("Name", p.Name.ToString());
            var document = collection.Find(filter).First();
            var m = BsonSerializer.Deserialize<Patient>(document);
            NewPatient np = new NewPatient();
            np.Age = m.Age;
            np.Info = m.Info;
            np.Encounters = m.Encounters;
            np.Name = m.Name;
            np.Encounters.Add(new Encounter(p.Date, p.ChiefComplaints, p.HistoryIllness, p.PastHistory, p.PhysicalExam,
                p.Tests, p.Diagnosis, p.Treatment, p.Prescriptions, p.Referrals));
            string json = JsonConvert.SerializeObject(np);
            MongoDB.Bson.BsonDocument document2
                = MongoDB.Bson.Serialization.BsonSerializer.Deserialize<BsonDocument>(json);
            collection.DeleteOne(filter);
            collection.InsertOne(document2);
            return Content(json);
        }

        [HttpPost]
        public IActionResult PhysicalExam(Patient p)
        {
            return View(p);
        }

        [HttpPost]
        public IActionResult Tests(Patient p)
        {
            return View(p);
        }

        [HttpPost]
        public IActionResult Diagnosis(Patient p)
        {
            return View(p);
        }

        [HttpPost]
        public IActionResult Treatment(Patient p)
        {
            return View(p);
        }

        [HttpPost]
        public IActionResult Prescriptions(Patient p)
        {
            return View(p);
        }

        [HttpPost]
        public IActionResult Referrals(Patient p)
        {
            return View(p);
        }

        [HttpPost]
        public IActionResult Full(Patient p)
        {
            return View(p);
        }

        // POST: ENCOUNTER/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ENCOUNTER/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ENCOUNTER/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ENCOUNTER/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ENCOUNTER/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}