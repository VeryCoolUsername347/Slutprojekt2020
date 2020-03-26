using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slutprojekt2020
{
    class FriendlyNPC : NPC
    {
        public int friendlyScary = -5;
        public int friendlyInnocent = +5;
        public FriendlyNPC()
        {
            npcStats[0] += friendlyScary;
            npcStats[2] += friendlyInnocent;
            for (int i = 0; i < npcStats.Length; i++)
            {

            }
        }
    }
}
