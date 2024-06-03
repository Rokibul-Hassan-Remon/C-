using UsingOOPsConceptLibraryManagement.FollowingOOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingOOPsConceptLibraryManagement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Book book1 = new Book(1, "Microprocessor", 250);
            Book book2 = new Book(2, "Computer Organization and Architecture", 500);
            Book book3 = new Book(3, "Java Programming", 1050);

            BookShelf shelf1 = new BookShelf(1, "RFL", 1000);
            BookShelf shelf2 = new BookShelf(2, "Bengal Plastic", 750);

            Chair chair1 = new Chair(1, "RFL Comfort Chari", 500);
            Chair chair2 = new Chair(2, "RFL Comfort Chari", 500);
            Chair chair3 = new Chair(3, "RFL Comfort Chari", 500);
            Chair chair4 = new Chair(4, "RFL Comfort Chari", 500);
            Chair chair5 = new Chair(5, "RFL Comfort Chari", 500);
            Chair chair6 = new Chair(6, "RFL Comfort Chari", 500);
            Chair chair7 = new Chair(7, "RFL Comfort Chari", 500);
            Chair chair8 = new Chair(8, "RFL Comfort Chari", 500);

            User user1 = new User(1, "Remon", "Student", "cse19015@gmail.com");
            User user2 = new User(2, "Abdul Kadir", "Teacher", "abdulkadir12@gmail.com");

            Libraryian Admin = new Libraryian(1, "Mostofa", "Admin", "adminmostofa@gmail.com");

            Library lib = new Library();

            lib.addPeople(user1);
            lib.addPeople(user2);
            lib.addPeople(Admin);

            lib.addItem(chair1);
            lib.addItem(chair2);
            lib.addItem(chair3);
            lib.addItem(chair4);
            lib.addItem(chair5);
            lib.addItem(chair6);
            lib.addItem(chair7);
            lib.addItem(chair8);

            lib.addItem(book1);
            lib.addItem(book2);
            lib.addItem(book3);

            lib.addItem(shelf1);
            lib.addItem(shelf2);


            lib.displayEntireLibrary();

            Console.ReadLine(); 

        }
    }
}
