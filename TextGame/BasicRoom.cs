using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGame
{
	public class BasicRoom : BasicEntity
	{
		public string Description;
        public Dictionary<string, Guid> Connection;

		public BasicRoom()
		{
			Description = string.Empty;
            Connection = new Dictionary<string, Guid>();
		}

        public void SetRoomInfo(string name, string desc)
        {
            this.Name = name;
            this.Description = desc;
        }

        public void AddRoomConnection(string direction, Guid roomId)
        {
            direction.ToLower();

            if (!Connection.ContainsKey(direction))
                Connection.Add(direction, roomId);
        }
	}
}
