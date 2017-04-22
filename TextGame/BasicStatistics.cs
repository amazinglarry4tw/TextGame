using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGame
{
    public class BasicStatistics
    {
        public Dictionary<string, int> Stats;

        public BasicStatistics()
        {
            Stats = new Dictionary<string, int>();
            Stats.Add("Strength", 0);
            Stats.Add("Constitituion", 0);
        }
    }
}
