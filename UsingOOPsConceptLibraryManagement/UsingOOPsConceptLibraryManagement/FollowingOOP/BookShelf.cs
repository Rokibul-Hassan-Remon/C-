using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingOOPsConceptLibraryManagement.FollowingOOP
{
    public class BookShelf:Item
    {
        public BookShelf(int id, string name, int price) : base(id, name, price)
    {

    }

    public override void displayItem()
    {
        Console.WriteLine(
            "Serial No of  the bookShelf " + Id + 
            "\nName of the BookShelf: " + Name +
            "\nPrice of the bookShelf: " + Value
            );
    }
}
}
