using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymTracker.Classes
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string SecurityQues { get; set; }
        public string SecurityAns { get; set; }

        public User(string username, string pass, string ques, string answ)
        {
            Username = username;
            Password = pass;
            SecurityQues = ques;
            SecurityAns = answ;
        }

        public User()
        {
            
        }
    }
}
