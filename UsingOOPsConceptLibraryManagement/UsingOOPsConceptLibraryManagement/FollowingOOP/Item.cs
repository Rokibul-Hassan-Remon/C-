using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingOOPsConceptLibraryManagement.FollowingOOP
{
    public abstract class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Value {  get; set; }
        public abstract void displayItem();
        
        public Item(int id, string name,int value)
        {
            Id = id;
            Name = name;
            Value = value;
        }
    }
}
