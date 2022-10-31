namespace The_Fountain_of_objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Välj storlek på kartan med ett heltal (antal rutor) ");
            int inputMap = int.Parse(Console.ReadLine());
            int[,] map = new int[inputMap, inputMap];
            Move.GetMapSize(inputMap);
            Console.WriteLine($"En karta har skapats med {inputMap}x{inputMap}");
            Console.WriteLine("Du kan förflytta dig genom att skriva \"move\" följt av värdestreck tex north");
            while (true)
            {
                Console.WriteLine("--------------------------");
                //Console.Write("In what direction do you want to move? ");
                //string? inputMove = Console.ReadLine();
                Move.Movement();
                Console.WriteLine("--------------------------");
            }
        }
    }
}