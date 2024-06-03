using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingOOPsConceptLibraryManagement.FollowingOOP
{
    public  class User:People
    {
        public User(int id, string name, string profession, string email) : base(d, name, profession, email)
        {

        }

        public override void displayDetails()
        {
            Console.WriteLine(
                "Name of the User: " + Name + 
                "\nId: " + Id +
                "\nProfession : " + Profession +
                "\n\n"
                );
        }

    }
}
