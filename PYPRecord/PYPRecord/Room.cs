using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PYPRecord
{
    public class Room
    {
        public static  int Counter = 0;
        public int Id { get; }
        public string Name { get; set; }
        public double Price { get; set; }
        public byte PersonCapacity { get; set; }
        public bool IsAvailable { get; set; }
        public Room(string name, double price, byte personCapacity)
        {
            Counter++; //1 2
            Id = Counter; // 1 2
            Name = name;
            Price = price;
            PersonCapacity = personCapacity;
            IsAvailable = true;
        }

        public string ShowInfo()
        {
            return $"Id = {Id} Name= {Name} Available : {IsAvailable}";
        }

        public override string ToString()
        {
            return ShowInfo();
        }
    }
}
