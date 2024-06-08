using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultidimensionalArray
{
    internal class Program
    {

        public void printing(int[,] ar)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(ar[i, j]+" ");
                }
                Console.WriteLine();
            }


        }
        static void Main(string[] args)
        {
            Program p = new Program();

            int[,] ar = new int[3, 3];
            int k = 1;

            for(int i=0; i< 3; i++)
                for(int j = 0; j < 3; j++)               
                    ar[i, j] = k++;
            p.printing(ar);

            Console.ReadLine();
            
        }
    }
}
