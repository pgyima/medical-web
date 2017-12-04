using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMR.Models.Patient
{
    public class Info
    {

        public int Age { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public string Phone { get; set; }
        public string DOB { get; set; }
        public string PrimaryIns { get; set; }
        public string PrimaryPhys { get; set; }
        public string Allergies { get; set; }
        public string CurrentMedications { get; set; }


        public Info() {
            Age = 0;
            Height = "height";
            Weight = "weight";
                Gender = "gender"; Address = ""; City = "";State = "";Zipcode = "";
            Phone = "";DOB = "";PrimaryIns = ""; PrimaryPhys = "";Allergies = "no known allergies";
            CurrentMedications = "No current medications";



        }

        public Info(int age, string height, string weight, string gender, string address, string city, string state, string zip, string phone, string dob, 
            string primaryIns, string primaryPhys, string allergies, string currentMedications) {

            Age = age;
            Height = height;
            Weight = weight;
            Gender = gender;

            Address = address;
            City = city;
            State = state;
            Zipcode = zip;
            Phone = phone;
            DOB = dob;
            PrimaryIns = primaryIns;
            PrimaryPhys = primaryPhys;

            Allergies = allergies;
            CurrentMedications = currentMedications;





        }





    }






}
