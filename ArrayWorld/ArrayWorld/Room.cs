using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayWorld
{
    class Room
    {
        public string Description { get; set; }
        public List<Room> levels = new List<Room>();

        public Room()
        {
            Description = "There is nothing here. This part of the world is empty.";            
        }
        public void PrintRoom()
        {
            Console.Write($"{Description} | ");
        }
    }
}
