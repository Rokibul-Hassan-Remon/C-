using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingOOPsConceptLibraryManagement.FollowingOOP
{
    internal class Chair : Item
    {
        public Chair(int id, string name, int price) : base(id, name, price)
        {

        }

        public override void displayItem()
        {
            Console.WriteLine(
                "Serial No of  the chair: " + Id + 
                "\nName of the chair: " + Name + 
                "\nPrice of the chair: " + Value+
                "\n\n"
                );
        }
    }
}
