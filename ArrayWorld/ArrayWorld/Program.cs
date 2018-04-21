using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayWorld
{
    class Program
    {
        public static Room[,] world = new Room[10, 10];
        static void Main(string[] args)
        {                        
            for(int i = 0; i <= world.Length; i++)
            {
                for(int j = 0; j < world.Length - 1; j++)
                {
                    world[i, j] = new Room();
                }
            }
            PrintAllRooms();
            Console.ReadKey();
        }
        private static void PrintAllRooms()
        {
            for (int i = 0; i < world.Length; i++)
            {
                for (int j = 0; j <= world.Length; j++)
                {
                    world[i, j].PrintRoom();
                }
                Console.WriteLine("");
            }
        }
    }
}
