using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Masjid_Management
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ManagingCommite President = new ManagingCommite("Dulal", "President", 5000);
            ManagingCommite Secratery = new ManagingCommite("Asad", " Secratery ", 2000);
            ManagingCommite Cashier = new ManagingCommite("Noman", "Cashier", 1000);
            ManagingCommite Chairmen = new ManagingCommite("Ahmed", "Chairmen");
            ManagingCommite ViceChairmen = new ManagingCommite("Robiul", "ViceChairmen", 1500);

            GeneralMember Raju = new GeneralMember("Raju", "GeneralMember", 50);
            GeneralMember Remon = new GeneralMember("Remon", "GeneralMember", 150);
            GeneralMember Rakib = new GeneralMember("Rakib", "GeneralMember", 1);
            GeneralMember Russel = new GeneralMember("Russel", "GeneralMember", 50);

            Volunteer v1 = new Volunteer("Amin", "Volunteer ", 20);
            Volunteer v2 = new Volunteer("Rofiq", "Volunteer ");
            Volunteer v3 = new Volunteer("Raj", "Volunteer ");
            Volunteer v4 = new Volunteer("Faruq", "Volunteer ");

            Prayer Imam = new Prayer("Omar", "Imam", 50);
            Prayer Muazzin = new Prayer("Abu Bakkar", "Muazzin ");

            Job Edul_Adj_Ha = new Job("Edul_Adj_Ha", "06/7/2024", 1500);
            Job StructuralDevelopment = new Job("2nd Floor ceiling Concritize", "08/08/2024", 150000);



            Mangement Management = new Mangement();

            Management.AddPeople(President);
            Management.AddPeople(Secratery);
            Management.AddPeople(Cashier);
            Management.AddPeople(Chairmen);
            Management.AddPeople(ViceChairmen);
            Management.AddPeople(Raju);
            Management.AddPeople(Remon);
            Management.AddPeople(Rakib);
            Management.AddPeople(Russel);
            Management.AddPeople(v1);
            Management.AddPeople(v2);
            Management.AddPeople(v3);
            Management.AddPeople(v4);
            Management.AddPeople(Imam);
            Management.AddPeople(Muazzin);

            Management.Additems(Edul_Adj_Ha);
            Management.Additems(StructuralDevelopment);

            Management.ShowPeopleInfo();
            Management.ShowEventDetails();

            Console.WriteLine($"Total amount : {Management.TotalAmount}");


        }
    }
}
