using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGame
{
	class Program
	{
        static PlayerCharacter pc = new PlayerCharacter();
        static BasicRoom rm = new BasicRoom();

        static void Main(string[] args)
		{
            Setup();

            Console.WriteLine(string.Format("{0} has {1} Constitution and {2} Health.", pc.Name, pc.Stats.Constitution, pc.Health));
            Console.WriteLine(string.Format("{0}\n{1}", rm.Name, rm.Description));
            Console.ReadLine();
		}

        static void Setup()
        {
            pc.Stats.Constitution = 25;
            pc.GenerateInfo();
            pc.Name = "Jeremy";

            rm.SetRoomInfo("Town Square Central", "This room is as crazy as it is big.  It's wild.");
        }
	}
}
