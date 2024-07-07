using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumaration
{
    internal class Program
    {

        enum MonthName
        {
            January = 3,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December

        }



        static void Main(string[] args)
        {
           ///// string[] mnthname = Enum.GetNames(typeof(MonthName));
            MonthName[] values = (MonthName[ ])Enum.GetValues(typeof(MonthName)); 

            try
            {
                    for( int i = 0; i < values.Length; i++ ) {
                    Console.WriteLine(values[i] + " value = " + (int)values[i]);
                }

            }
            catch (ArgumentException)
            {
                Console.WriteLine("this is invalid");
                
            }

            Console.ReadLine();
        

    }

    }

}
