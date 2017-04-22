using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGame
{
    public class BasicPlayerCharacter : BasicEntity
    {
        public int Health;
        public CoreStats Stats;

        public BasicPlayerCharacter()
        {
            Health = 0;
            Stats = new CoreStats();
        }

        public void GenerateInfo()
        {
            CalculateBaseHealth();
        }

        protected void CalculateBaseHealth()
        {
            Health = 20 + Convert.ToInt32(Stats.Constitution * 0.9);
        }
    }
}
