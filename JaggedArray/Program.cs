using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    internal class Program
    {

        public void printingJaggedArray(int[][] array)
        {
            for(int j = 0; j< array.Length; j++)
            {
                for(int i = 0; i < array[j].Length; i++)
                {
                    Console.Write(array[j][i] + " ");
                }
                Console.WriteLine();
            }


        }
        static void Main(string[] args)
        {
            int[][] jaggedArray = new int[3][];

            jaggedArray[0] = new int[3];
            jaggedArray[1] = new int[2];
            jaggedArray[2] = new int[4];

            int k = 1;
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    jaggedArray[i][j] = k++;
                }
            }

            Program p = new Program();

            p.printingJaggedArray(jaggedArray);
            Console.ReadLine();

        }
    
    }
}
