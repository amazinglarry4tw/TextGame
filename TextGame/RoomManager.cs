using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGame
{
    public class RoomManager
    {
        public List<BasicRoom> GameRooms;

        public RoomManager()
        {
            GameRooms = new List<BasicRoom>();
        }

        public void AddRoom(BasicRoom room)
        {
            if (RoomDoesNotExist(room.Id))
                GameRooms.Add(room);
        }

        public BasicRoom GetRoom(Guid roomId)
        {
            BasicRoom temp = new BasicRoom();

            for (int i = 0; i < GameRooms.Count; i++)
            {
                if (GameRooms[i].Id == roomId)
                {
                    temp = GameRooms[i];
                    i = GameRooms.Count;
                }
            }

            return temp;
        }

        public void ConnectRoom(Guid sourceRoomId, string direction, Guid destinationRoomId)
        {
            BasicRoom sourceRoom = GetRoom(sourceRoomId);

            if (sourceRoom.Id != Guid.Empty)
                sourceRoom.AddRoomConnection(direction, destinationRoomId);
        }

        public bool RoomDoesNotExist(Guid roomId)
        {
            bool doesNotExist = true;

            for (int i = 0; i < GameRooms.Count; i++)
            {
                if (GameRooms[i].Id == roomId)
                {
                    doesNotExist = false;
                    i = GameRooms.Count;
                }
            }

            return doesNotExist;
        }

        public bool RoomExists(Guid roomId)
        {
            bool exists = false;

            for (int i = 0; i < GameRooms.Count; i++)
            {
                if (GameRooms[i].Id == roomId)
                {
                    exists = true;
                    i = GameRooms.Count;
                }
            }

            return exists;
        }
    }
}
