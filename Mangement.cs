using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masjid_Management
{
    public class Mangement
    {
        public List<People> MemberTrack = new List<People>();
        public List<Job> job = new List<Job>();

       public int TotalAmount = 0;

        public void AddPeople(People peoples)
        {
            MemberTrack.Add(peoples);
        }

        public void Additems(Job Jobs)
        {
            job.Add(Jobs);
        }

        public void ShowPeopleInfo()
        {
            foreach(People p in MemberTrack)
            {
                p.donarInfo();
               TotalAmount += p.amount;
            }
        }
        /// <summary>
        /// Console.WriteLine($"Total amount : {TotalAmount}");
        /// </summary>

        public void ShowEventDetails()
        {
            foreach(Job jobs in job)
            {
                jobs.EventDetails();
            }
        }


    }
}
