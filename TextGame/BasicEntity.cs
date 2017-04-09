using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGame
{
	public class BasicEntity
	{
		public string Name;
		public Guid Id;

		public BasicEntity()
		{
			Name = string.Empty;
			Id = Guid.NewGuid();
		}
	}
}
