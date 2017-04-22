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
            BasicPlayerCharacter pc = new BasicPlayerCharacter();
            pc.Stats.Constitution = 90;
            pc.GenerateInfo();
            pc.Name = "Jeremy";

            Console.WriteLine(string.Format("{0} has {1} Constitution and {2} Health.", pc.Name, pc.Stats.Constitution, pc.Health));
            Console.ReadLine();
		}
	}
}
