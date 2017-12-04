using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMR.Models.Patient
{
    public class Encounter
    {
        
        public string Date { get; set; }
        public List<string> ChiefComplaints { get; set; }
        public string HistoryIllness { get; set; }
        public string PastHistory { get; set; }
        public string PhysicalExam { get; set; }
        public string Tests { get; set; }
        public string Diagnosis {get;set;}
        public string Treatment { get; set; }
        public string Prescriptions { get; set; }
        public string Referrals { get; set; }


        public Encounter() {
            Date = "";
            ChiefComplaints = new List<string>();
            HistoryIllness = "";
            PastHistory = "";
            PhysicalExam = "";
            Tests = "";
            Diagnosis = "";
            Treatment = "";
            Prescriptions = "";
            Referrals = "";
            
        }


        public Encounter(string date, List<string> chiefComplaints, string history_illness, string past, string pe, string tests, string dx, string tx, string rx, string rf) {

            Date = date;
            ChiefComplaints = chiefComplaints;
            HistoryIllness = history_illness;
            PastHistory = past;
            PhysicalExam = pe;
            Tests = tests;
            Diagnosis = dx;
            Treatment = tx;
            Prescriptions = rx;
            Referrals = rf;
         }
        


        



    }
}
