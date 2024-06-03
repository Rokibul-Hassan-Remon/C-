using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input the student no :\n");
            Int32 a = Convert.ToInt32(Console.ReadLine());
           
            string grade;

            switch (a/10)
            { 
              case 10:

              case 9:
                
              case 8:
                    grade = "A+";
                    break;

              case 7:
                     grade = "A";
                     break;
              case 6:
                    grade = "A-";
                    break;
              case 5:
                    grade = "B";
                    break;
              case 4:
                    grade = "C";
                    break;
              case 3:
                    grade = "D";
                    break;
              default :
                    grade = "F";
                    break;
            }

            Console.WriteLine(grade);
            Console.ReadLine();

        }
    }
}
