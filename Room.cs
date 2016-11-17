using System;


namespace TextAdventure
{
    public class Room
    {

        //Variables
        public string RoomName;
        public string Description;

        //Possible exits
        public Room North = null;
        public Room East = null;
        public Room South = null;
        public Room West = null;


        //Room Constructor
        public Room(string roomname, string description)
        {
            //Room Name
            RoomName = roomname;
            //Room Description
            Description = description;
    }

        static public void DescribeRoom(Room room)
        {   
            //Print RoomName
            Console.WriteLine(Environment.NewLine + room.RoomName);
            //Print a divider
            Console.WriteLine(" ".PadLeft(room.RoomName.Length + 1, '-'));
            //Print Room Discription
            Console.WriteLine(Environment.NewLine + room.Description);
            
            //Print a divider
            Console.WriteLine(" ".PadLeft(room.RoomName.Length + 1, '-'));


            //Exit

            //To print
            string n;
            string e;
            string s;
            string w;

            //Set Vars
            if (room.North == null)
            {
                n = "";
            }
            else
            {
                 n = "(N)orth ";
            }
            if (room.East == null)
            {
                e = "";
            }
            else
            {
                e = "(E)ast ";
            }
            if (room.South == null)
            {
               s = "";
            }
            else
            {
               s = "(S)outh ";
            }
            if (room.West == null)
            {
                w = "";
            }
            else
            {
                w = "(W)est ";
            }
            //print the fuck !
            Console.WriteLine(n + e + s + w);
  


            /*
            //Exits .... immer 4 Zeilen :(
               if (room.North == null)
                {
                Console.WriteLine("");
                }
               else
                {
                Console.WriteLine("(N)orth\n");
                }
                if (room.East == null)
                {
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("(E)ast\n");
                }
                if (room.South == null)
                {
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("(S)outh\n");
                }
                if (room.West == null)
                {
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("(W)est\n");
                }
                */

            //Print a divider
            Console.WriteLine(" ".PadLeft(room.RoomName.Length + 1, '-'));

            //Player Coice
            Console.WriteLine("\nWhere do you want to go?         Or (Q)uit?");

        }

    }
}
