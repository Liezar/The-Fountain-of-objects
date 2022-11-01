namespace The_Fountain_of_objects
{
    internal class Move
    {
        static int _mapX;
        static int _mapY;

        static int x = 0;
        static int y = 0;

        static int objectX = 2;
        static int objectY = 0;

        public static void GetMapSize(int inputMap)
        {
            _mapX = inputMap;
            _mapY = inputMap;
        }
        public static void Movement()
        {
            bool fountainOn = false;
            bool incorrectMove = true;
            bool gameRunning = true;
            
            do
            {
                Console.Write("In what direction do you want to move? ");
                string? userInput = Console.ReadLine();

                if (userInput == "move north" || userInput == "move south" || userInput == "move west" || userInput == "move east")
                {
                    if (userInput == "move north" && y != _mapY - 1)
                    {
                        y++;
                        incorrectMove = false;
                    }
                    else if (userInput == "move north" && y == _mapY - 1) Console.WriteLine("You hit the wall");


                    if (userInput == "move south" && y != 0)
                    {
                        y--;
                        incorrectMove = false;
                    }
                    else if (userInput == "move south" && y == 0) Console.WriteLine("You hit the wall");


                    if (userInput == "move west" && x != 0)
                    {
                        x--;
                        incorrectMove = false;
                    }
                    else if (userInput == "move west" && x == 0) Console.WriteLine("You hit the wall");


                    if (userInput == "move east" && x != _mapX - 1)
                    {
                        x++;
                        incorrectMove = false;
                    }
                    else if (userInput == "move east" && x == _mapX - 1) Console.WriteLine("You hit the wall");
                }
                else if (true)
                {
                    Console.WriteLine("incorrect movement, try again");
                }
                Console.WriteLine($"You moved to X:[{x}] Y:[{y}]\n------------------------");

                if (x == objectX && y == objectY && fountainOn == false) // object placement
                {
                    Console.WriteLine("You hear water dripping in this room. The Fountain of Objects\r\nis here!");
                    string userInput2 = Console.ReadLine();
                    if (userInput2 == "enable fountain")
                    {
                        Console.WriteLine("You hear the rushing waters from the Fountain of Objects. It has been reactivated!");
                        fountainOn = true;
                    }

                }

                if (x == 0 && y == 0 && fountainOn == false)
                {
                    Console.WriteLine("You see light in this room\r\ncoming from outside the cavern. This is the entrance.");
                }
                if (x == 0 && y == 0 && fountainOn == true)
                {
                    Console.WriteLine("The Fountain of Objects has been reactivated, and you have escaped with your life!\r\nYou win!");
                    gameRunning = false;

                }

            } while (gameRunning);
        }
    }
}
