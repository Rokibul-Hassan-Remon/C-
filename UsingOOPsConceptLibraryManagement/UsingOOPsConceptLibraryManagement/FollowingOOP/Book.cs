using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingOOPsConceptLibraryManagement.FollowingOOP
{
    public class Book:Item
    {
        public Book(int id,string name,int price): base(id,name,price) 
        {
            
        }

        public override  void displayItem()
        {
            Console.WriteLine(
                "Name of the Book: "+ Name+ 
                "\nSerial No of  the book: " + Id +               
                "\nPrice of the book: " + Value+
                "\n\n"
                );
        }
    }
}
