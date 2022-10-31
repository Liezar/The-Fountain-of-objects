using System.Security.Cryptography.X509Certificates;

namespace The_Fountain_of_objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var grid = Map.Grid(4);

            foreach (var item in grid)
            {
                Console.WriteLine(item);
            }

        }
    }
}