using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MongoDB.Driver;
using MongoDB.Bson;
using Newtonsoft.Json;

using EMR.Models;
using MongoDB.Bson.Serialization;

namespace EMR.Models.Patient
{
    

    public class NewPatient
    {
        //For entry INTO mongodb
       
        public string Name { get; set; }
        public int Age { get; set; }
        public List<Encounter> Encounters { get; set; }
        public Info Info { get; set; }

        public string Date { get; set; }

        public string ChiefComplaintsStr { get; set; }
        public List<string> ChiefComplaints;
        public string HistoryIllness { get; set; }
        public string PastHistory { get; set; }
        //public string Additional_Notes { get; set; }
        // public string Review_Systems { get; set; }
        public string PhysicalExam { get; set; }
        public string Tests { get; set; }
        public string Diagnosis { get; set; }
        public string Treatment { get; set; }
        public string Prescriptions { get; set; }
        public string Referrals { get; set; }



        public NewPatient(
            ) {
            Name = "name";
            Age = 0;
            Encounters = new List<Encounter>();
            Info = new Info();
            Date = "o";
            ChiefComplaintsStr = "";
            ChiefComplaints = new List<string>();
            HistoryIllness = "o";
            PastHistory = "o";
            PhysicalExam = "o";
            Tests = "o";
            Diagnosis = "o";
            Treatment = "o";
            Prescriptions = "o";
            Referrals = "o";
        }
        public NewPatient(string name, int age, List<Encounter> encounters, Info info)
        {
           
            Name = name;
            Age = age;
            Encounters = encounters;
            Info = info;
        }


    }
}