using System.Collections.Generic;

namespace CoronaApp.Dal
{
    public class Patient
    {
        public Patient()
        {
        }

        public Patient(int id)
        {
            PatientId = id;
            Path = new List<Location>();
        }
        public Patient(int id, Location location) : this(id)
        {
            Path.Add(location);
        }
        public int PatientId { get; set; }
        public List<Location> Path { get; set; }
    }
}