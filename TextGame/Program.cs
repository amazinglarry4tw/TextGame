using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGame
{
	class Program
	{
        static InputManager IM = new InputManager();
        public static PlayerCharacter pc = new PlayerCharacter();
        public static RoomManager rm = new RoomManager();
        public static ActionManager am = new ActionManager();
        static string Input = string.Empty;

        static void Main(string[] args)
		{
            Setup();

            //Console.WriteLine(string.Format("{0} has {1} Constitution and {2} Health.", pc.Name, pc.Stats.Constitution, pc.Health));
            Console.WriteLine(string.Format("{0}\n{1}", rm.GameRooms[0].Name, rm.GameRooms[0].Description));

            while (Input != "exit")
            {
                Input = Console.ReadLine();
                IM.HandleInput(Input);
            }
		}

        static void Setup()
        {
            pc.Stats.Constitution = 25;
            pc.GenerateInfo();
            pc.Name = "Jeremy";

            BasicRoom room1 = new BasicRoom();
            room1.SetRoomInfo("Town Square Central", "This is the main room in the game.  It's where merchants and players will gather.");
            rm.AddRoom(room1);

            BasicRoom room2 = new BasicRoom();
            room2.SetRoomInfo("Staging Area", "The staging area is where players will gather to spell up before they go out into the wilds.");
            rm.AddRoom(room2);

            rm.ConnectRoom(room1.Id, "west", room2.Id);
            rm.ConnectRoom(room2.Id, "east", room1.Id);
        }
	}
}
