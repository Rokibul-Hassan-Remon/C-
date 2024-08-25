using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace Masjid_Management
{
    public class People :Donation
    {
       
        public String Name { get; set; } 
        public String Designation { get; set; }
       
        public People(string name, string position, int donate) :base(donate)
        {
            Name = name;
            Designation = position;
        }

        public override void donarInfo()
        {
            Console.WriteLine($"position : {Designation},Name:{Name} ,total amount of money : {amount}");
        }



    }



}
