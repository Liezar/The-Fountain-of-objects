using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Fountain_of_objects
{
    public class Grid
    {
        public static void CreateGrid(int size)
        {
            Console.WriteLine("Skriv in hur stor mapp");

            int x = 0;
            int y = 0;

            for (int i = 0; i < size; i++)
            {
                int[,] grid = new int[x++, y++];
                Console.WriteLine(grid.GetLength(0)); //rows
                Console.WriteLine(grid.GetLength(1)); //Columns 
            }
        }
    }
}
