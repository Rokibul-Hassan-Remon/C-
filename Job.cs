using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masjid_Management
{
    internal class Job
    {

        public String EventName { get; set; }
        public int MoneyToBeNeeded { get; set; }

        public String Date { get; set; }

        public Job(string name, string date , int Money)
        {
            EventName = name;
            Date = date;
            MoneyToBeNeeded = Money;
            
        }

        public void EventDetails()
        {
            Console.WriteLine($"EventName : {EventName} \n Date : {Date} \n Approximate amount of money to be needed : {MoneyToBeNeeded} will be organized by the Mosjid comitte  ");
        }

        
    }
}
