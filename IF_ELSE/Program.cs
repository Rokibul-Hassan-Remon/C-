using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF_ELSE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Int32 num;
            Console.WriteLine("Please input the student no \n");
            num = Convert.ToInt32(Console.ReadLine());

            if (num >= 90 && num <= 100)
                Console.WriteLine("A+");

            else if (num >= 80 && num < 90)
                Console.WriteLine("B");

            else if (num >= 70 && num < 80)
                Console.WriteLine("C");

            else if (num >= 60 && num < 70)
                Console.WriteLine("D");

            else
                Console.WriteLine("F");

            Console.ReadLine();
        }
    }
}
