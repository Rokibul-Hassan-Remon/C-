﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiffrentTypeOfLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Int32 a = 10,i;

            for ( i = 1; i <= a; i++)
                Console.WriteLine(i);


            Console.WriteLine("\n");

             i = 1;

            while (i <= a)
            {
                Console.WriteLine(i);
                i++;
            }

            Console.WriteLine("\n");
            i = 1;

            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i <= a);

            Console.WriteLine();

            Console.ReadLine();
        }
    }

}
