using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingOOPsConceptLibraryManagement.FollowingOOP
{
    public class Libraryian : People
    {
        public Libraryian(int id,string name,string profession,string email): base(id,name,profession,email) 
        {
            
        }


        public override void displayDetails()
        {
            Console.WriteLine(
                
                "Name of the User: " + Name + 
                "\nId: " + Id +
                "\nProfession : " +Profession + 
                "\n\n"
                );
        }


    }
}
