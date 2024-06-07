using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 *  difference between reference type and value type
 *  Ans:
 *                    Refrence                                                             Value
 *          It's take input as a refrence type of variable              It's take input as a normal variable
 *          
 *          before data type use 'ref'                                  before data type no keyword is used
 *          
 *          what changes inside the function ,                           Changes get effect on its own function but
 *          the same changes effect on the main                           no effect in the main method
 *              method
 *                                        
 * 
 * 
 */

namespace Value_Ref_Out_Function
{
    internal class Program
    {

        public void valueType(int value)
        {
            Console.WriteLine("It is a value type function.\n That's " +
                "why it can return one value and any changes on this code no effect shows in the main method");
             Console.WriteLine(value * value);
        }

        public void refType(ref int value)
        {
            value = value - 10;
            Console.WriteLine("this is the ref type of function\n  " +
                "That's why any changes on this value of variable same changes on the main method");

        }

        public void ooutType(int rad,out double area, out double periferial)
        {
            area = 3.1416f * (rad * rad);
            periferial = 2 * (3.1416f) * rad;
            Console.WriteLine("this is the out type of function\n" +
                " That's why multiple value can return");
        }

        static void Main(string[] args)
        {
            Program program = new Program();

            int a = 100;
            program.valueType(a);


            program.refType(ref a);

           Console.WriteLine(a);


            program.ooutType(a, out double area, out double periferial);
            Console.WriteLine("Radious of a circle : " + a + "\nArea : " + area + "\nPeriferial of circle " + periferial);
            Console.ReadLine();


        }
    }
}
