using System.Collections.Generic;

namespace PulseAthlete.Resources.Models
{
    static class Team
    {
        public static List<Athlete> athlete = new List<Athlete>();
    }

    public class Athlete
    {
        public string name { get; set; }
        public int age { get; set; }
        public int restingHR { get; set; }
        public double targetHRmin { get; set; }
        public double targetHRmax { get; set; }
        //public int userID { get; set; }
    }
}
