namespace The_Fountain_of_objects
{
    internal class Move
    {
        static int _mapX;
        static int _mapY;

        static int x = 0;
        static int y = 0;

        public static void GetMapSize(int inputMap)
        {
            _mapX = inputMap;
            _mapY = inputMap;
        }
        public static void Movement()
        {
            bool incorrectMove = true;
            while (incorrectMove == true)
            {
                Console.Write("In what direction do you want to move? ");
                string? inputMove = Console.ReadLine();

                if (inputMove == "move north" || inputMove == "move south" || inputMove == "move west" || inputMove == "move east")
                {
                    if (inputMove == "move north" && x != _mapX - 1)
                    {
                        x++;
                        incorrectMove = false;
                    }
                    else if (inputMove == "move north" && x == _mapX - 1) Console.WriteLine("You hit the wall");


                    if (inputMove == "move south" && x != 0)
                    {
                        x--;
                        incorrectMove = false;
                    }
                    else if (inputMove == "move south" && x == 0) Console.WriteLine("You hit the wall");


                    if (inputMove == "move west" && y != 0)
                    {
                        y--;
                        incorrectMove = false;
                    }
                    else if (inputMove == "move west" && y == 0) Console.WriteLine("You hit the wall");


                    if (inputMove == "move east" && y != _mapY - 1)
                    {
                        y++;
                        incorrectMove = false;
                    }
                    else if (inputMove == "move east" && y == _mapY - 1) Console.WriteLine("You hit the wall");
                }
                else if (true)
                {
                    Console.WriteLine("incorrect movement, try again");
                }
            }
            Console.WriteLine($"You moved to X:[{x}] Y:[{y}]");
        }
    }
}
