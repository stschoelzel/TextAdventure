using System;
using System.Threading;


namespace TextAdventure
{
    public class Game
    {

        //Game Constructor
        public Game()
        {
            //Create Player
            Player = new Entity("Stranger");
        }

        //Player Intanz
        public Entity Player;



        //The Main Game Stuff
        public void Run()
        {

            //Create the Rooms
            Room playerRoom = Game.CreateRooms();

            //New Player Name
            Console.WriteLine("Hello " + Player.name + ". Do you have a Name?");
            if (yesno().Equals(true))
            {
                Console.WriteLine("\nSo, what should I call you?");
                Player.name = Console.ReadLine();
            }
            Console.WriteLine("\nOk " + Player.name + ". Let`s beginn... ");


            //Movement and Options
            bool quit = false;
            do
            {

                //Discribe playerRoom
                Room.DescribeRoom(playerRoom);

                //Direction Label
                Direction:
                //Direction Input
                string direction;
                Console.WriteLine("> ");
                direction = Console.ReadLine().ToUpper();
                
                 //Direction
                switch (direction)
                {
                    case "N":
                        if (playerRoom.North != null)
                            playerRoom = playerRoom.North;
                        break;
                    case "E":
                        if (playerRoom.East != null)
                            playerRoom = playerRoom.East;
                        break;
                    case "S":
                        if (playerRoom.South != null)
                            playerRoom = playerRoom.South;
                        break;
                    case "W":
                        if (playerRoom.West != null)
                            playerRoom = playerRoom.West;
                        break;
                    case "Q":
                        if (yesno().Equals(true))
                        {
                            Console.WriteLine("\nBye.");
                            quit = true;
                        }
                        break;
                    default:
                        Console.WriteLine(Player.name + " , I`m wating...");
                        goto Direction;
                }

            } while (quit == false);
        }

        static Room CreateRooms()
        {
            //First Room
            Room Testraum1 = new Room("Testraum Nummer 1", "To the North: 2. Testraum \nUm's schnell zu sehen: Raum XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            //Secound Room
            Room Testraum2 = new Room("Testraum Nummer 2", "To the South: 1. Testraum \nUm's schnell zu sehen: Raum YYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYY");
            //Thrid Room
            Room Testraum3 = new Room("Testraum Nummer 3", "To the West: 1. and 2. Testraum \nUm's schnell zu sehen: Raum whatever ... aber mit zwei räumen verbunden!");

            // Set Exits / Connections
                //Raum 1
                Testraum1.North = Testraum2;
                Testraum1.East = Testraum3;
                //Raum 2
                Testraum2.South = Testraum1;
                Testraum2.East = Testraum3;
                //Raum 3
                Testraum3.West = Testraum1;
                Testraum3.West = Testraum2;

            //Go to first room
            return Testraum1;
        }

        //Handels Yes/No Questions
        public bool yesno()
        {

            Console.WriteLine("\n(Y)es or (N)o");
            ConsoleKeyInfo cki = Console.ReadKey(true);
            bool answer = false;

            if (cki.Key == ConsoleKey.Y)
            {
                answer = true;
            }
            else if (cki.Key != ConsoleKey.N)
            {
                answer = yesno();
            }

            return answer;
        }

    }
}
