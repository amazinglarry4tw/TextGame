using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGame
{
	class Program
	{
		static void Main(string[] args)
		{
            PlayerCharacter pc = new PlayerCharacter();
            pc.Stats.Constitution = 0;
            pc.GenerateInfo();
            pc.Name = "Jeremy";

            Console.WriteLine(string.Format("{0} has {1} Constitution and {2} Health.", pc.Name, pc.Stats.Constitution, pc.Health));
            Console.ReadLine();
		}
	}
}
