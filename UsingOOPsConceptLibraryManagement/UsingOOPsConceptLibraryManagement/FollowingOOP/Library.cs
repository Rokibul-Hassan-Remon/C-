using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingOOPsConceptLibraryManagement.FollowingOOP
{
    internal class Library
    {
        public List<Item> Items = new List<Item>();
        public List<People> Peoples = new List<People>();

        public void addPeople(People newPeople)
        {
            Peoples.Add(newPeople);
            Console.WriteLine("Succesfully Added :" + newPeople.Name);
        }

        public void addItem(Item newItem)
        {
            Items.Add(newItem);
            Console.WriteLine("Succesfully Added :" + newItem.Name);
        }

        public void printingItem()
        {
            foreach (Item it in Items)
            {
                it.displayItem();
            }
            Console.WriteLine("");
        }

        public void printingWhoBelongsLibrary()
        {
            foreach (People pr in Peoples)
            {
                pr.displayDetails();
            }
            Console.WriteLine("");
        }

        public void displayEntireLibrary()
        {
            printingWhoBelongsLibrary();
            printingItem();
        }
    }

}
