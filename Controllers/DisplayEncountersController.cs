using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using EMR.Models;
using EMR.Models.AccountViewModels;
using EMR.Services;
using EMR.Models.Patient;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using Microsoft.AspNetCore.Http;

namespace EMR.Controllers
{
    public class DisplayEncountersController : Controller
    {

        private readonly UserManager<ApplicationUser> _userManager;

        public DisplayEncountersController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }



        // GET: DisplayEncounters
        public ActionResult Index(Patient p)
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var userId = _userManager.GetUserId(HttpContext.User);
            string db_name = "test" + userId;
            var database = client.GetDatabase(db_name);
            var collection = database.GetCollection<BsonDocument>("patients");
            var filter = Builders<BsonDocument>.Filter.Eq("Name", p.Name.ToString());

            var document = collection.Find(filter).First();
            var m = BsonSerializer.Deserialize<Patient>(document);
            List<Encounter> mm = m.Encounters;





            return View(mm);
        }

        // GET: DisplayEncounters/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DisplayEncounters/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DisplayEncounters/Create
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

        // GET: DisplayEncounters/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DisplayEncounters/Edit/5
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

        // GET: DisplayEncounters/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DisplayEncounters/Delete/5
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