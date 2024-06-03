using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingOOPsConceptLibraryManagement.FollowingOOP
{
    public abstract class People
    {
        public string Profession { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Id { get; set; }

        public abstract void displayDetails();

        public People(int userId, string name, string profession,string email)
        {
            Id = userId;
            Email = email;
            Name = name;
            Profession = profession;
        }
    }
}
