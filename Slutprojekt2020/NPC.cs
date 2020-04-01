using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slutprojekt2020
{
    class NPC
    {
        public int[] npcStats = new int[3];

        public void GenerateStats()
        {
            
            Random generator = new Random();
            for (int i = 0; i < npcStats.Length; i++)
            {
                npcStats[i] = generator.Next(1, 21);
            }
            
        }
    }
}
