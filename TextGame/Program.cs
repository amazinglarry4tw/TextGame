using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TextGame
{
	class Program
	{
        enum ActionType { MOVEMENT = 1, SPEECH, ATTACK, ROLEPLAY };
        static PlayerCharacter pc = new PlayerCharacter();
        static RoomManager rm = new RoomManager();
        static string input = string.Empty;

        static void Main(string[] args)
		{
            Setup();

            //Console.WriteLine(string.Format("{0} has {1} Constitution and {2} Health.", pc.Name, pc.Stats.Constitution, pc.Health));
            Console.WriteLine(string.Format("{0}\n{1}", rm.GameRooms[0].Name, rm.GameRooms[0].Description));

            while (input != "exit")
            {
                input = Console.ReadLine();
                HandleInput(input);
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

        static void HandleInput(string input)
        {
            if (input != "exit")
            {
                int type = EvaluateType(input);

                switch (type)
                {
                    case (int)ActionType.SPEECH:
                        Console.WriteLine("The player is trying to speak.");
                        break;
                    case (int)ActionType.MOVEMENT:
                        Console.WriteLine("The player is trying to move.");
                        break;
                    default:
                        Console.WriteLine("Not sure what the player is doing.  It has not been captured");
                        break;
                }
            }
        }

        static int EvaluateType(string input)
        {
            string temp = input.Trim();
            int type = 0;
            string[] parsedInput = ParseInput(temp);

            if (input[0].Equals('\'') || input[0].Equals('"') || parsedInput[0] == "say")
                type = (int)ActionType.SPEECH;
            else if (parsedInput[0].Equals("go") || parsedInput[0].Equals("move"))
                type = (int)ActionType.MOVEMENT;
            else
                type = 0;

            return type;
        }

        static string[] ParseInput(string input)
        {
            string temp = Regex.Replace(input, @"\s+", " ");
            string[] words = temp.Split(' ');
            return words;
        }
	}
}
