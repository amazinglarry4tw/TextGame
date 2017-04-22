using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGame
{
    public class PlayerCharacter : BasicPlayerCharacter
    {
        public Guid Location;

        public PlayerCharacter()
        {
            Location = Guid.Empty;
        }

        public void UpdatePlayerLocation(Guid roomId)
        {
            Location = roomId;
        }
    }
}
