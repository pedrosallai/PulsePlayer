using System.Collections.Generic;

namespace PulseAthlete.Resources.Models
{
    static class Account
    {
        public static List<User> user = new List<User>();
    }

    public class User
    {
        //public int ID { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    }
}
