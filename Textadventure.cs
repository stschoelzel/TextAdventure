using System;

namespace TextAdventure
{
    class Program
    {
        static void Main()
        {
            //hide cursor
            //Console.CursorVisible = false;

            //Create new Game
            Game game = new Game();

            //Run Game
            game.Run();

            //Game End

            //Cleanup
            Console.SetCursorPosition(
                0,
                Console.WindowHeight - 1
                );
        }
    }
}
