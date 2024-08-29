using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringClassFucntion
{
    internal class Program
    {
        static void Main(string[] args)
        {

            String s = "  I am Remon.I read in class 8 . Now , next year I will be going to Class 9. ";
            string fmly = "I live with my family . Now , I am 16 years old.";

            int length = s.Length;
            Console.WriteLine($" String starts with Remon! Is it true or false {s.StartsWith("Remon")} \t and this is also ends with going . Is it true or false{s.EndsWith("going")}"); ;
            Console.WriteLine(length);


            string substring = s.Substring(5, 10);
            Console.WriteLine(substring);

            Console.WriteLine($"In this String Remon word is present or not: {s.Contains("Remon")}");
            Console.WriteLine($" 8 is present in the string  {s.IndexOf('8')+1}th position ");
            string rplce = s.Replace("Remon", "Reo");
            Console.WriteLine(s.Substring(0, 8));

            string copy = string.Copy(s);
            Console.WriteLine($"Now its going to be upper case : Here is a sample : {copy.ToUpper()}");
            Console.WriteLine($"Now its going to be lower case : Here is a sample : {copy.ToLower()}");

            Console.WriteLine(s.Trim());
            string[] array = s.Split(' ');
            foreach(string st in array)
            {
                Console.WriteLine(st);
            }

            string nw_s = string.Join(" ", array);
            Console.WriteLine(nw_s);

            Console.WriteLine($"the string is empty {string.IsNullOrEmpty(s)}");



        }
    }
}
