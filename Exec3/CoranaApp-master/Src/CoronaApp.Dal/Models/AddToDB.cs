using System;
using System.Collections.Generic;
using System.Text;

namespace CoronaApp.Dal
{
  public  class AddToDB
    {
        public static List<Patient> patients = new List<Patient>() {
               new Patient() { PatientId  = 123456789, Path = new List<Location>() {
               new Location(){ City = "Jerusalem", StartDate = new DateTime(2019, 12, 23), EndDate = new DateTime(2019, 12, 25), LocationOfPerson = "Library" },
               new Location() { City = "Jafa", StartDate = new DateTime(2019, 10, 12), EndDate = new DateTime(2019, 11, 16), LocationOfPerson = "Library" },
               new Location() { City = "Tzfat", StartDate = new DateTime(2018, 3, 2), EndDate = new DateTime(2018, 3, 5), LocationOfPerson = "school" }
               }
           },
               new Patient() { PatientId  = 111111111, Path = new List<Location>() {
               new Location(){ City = "Jerusalem", StartDate = new DateTime(2019, 12, 23), EndDate = new DateTime(2019, 12, 25), LocationOfPerson = "Library" },
               new Location() { City = "Jafa", StartDate = new DateTime(2019, 10, 12), EndDate = new DateTime(2019, 11, 16), LocationOfPerson = "rav shafa" },
               new Location() { City = "Tzfat", StartDate = new DateTime(2018, 3, 2), EndDate = new DateTime(2018, 3, 5), LocationOfPerson = "school" }
               }
           },new Patient() { PatientId  = 222222222,Path = new List<Location>() {
              new Location() { City = "Jerusalem",StartDate = new DateTime(2019, 10, 25), EndDate = new DateTime(2019, 10, 25), LocationOfPerson = "Library" },
               new Location() { City = "Tel Aviv", StartDate = new DateTime(2019, 09, 12), EndDate = new DateTime(2019, 09, 16), LocationOfPerson = "fox" },
               new Location() { City = "Tel Aviv", StartDate = new DateTime(2018, 04 ,02), EndDate = new DateTime(2018, 04, 05), LocationOfPerson = "malch" }
               }
           },
           new Patient() {
        PatientId = 987654321, Path = new List<Location>() {
               new Location() { City = "Tel Aviv", StartDate = new DateTime(2018, 03, 02), EndDate = new DateTime(2018, 12, 26), LocationOfPerson = "school" },
               new Location() { City = "Givat zeev", StartDate = new DateTime(2020, 10, 29), EndDate = new DateTime(2020, 10, 24), LocationOfPerson = "school" }
               }
           } };
    }
}
