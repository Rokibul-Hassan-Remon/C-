using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDimensionalArray
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[,] array = new int[3, 5];       /// Declaration of 2D array

            array[0, 0] = 1;
            array[1, 1] = 2;
            array[2, 2] = 3;
            
           

            for(int i=0; i < 3; i++)
            {
                for(int j = 0; j< 5; j++)
                {
                    Console.Write(array[i, j]+ " ");
                }       
                Console.WriteLine();
            }

            Console.ReadLine();

        }
    }
}
