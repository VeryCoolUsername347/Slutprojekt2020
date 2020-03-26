using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slutprojekt2020
{
    class EvilNPC : NPC
    {
        public int evilyScary = -5;
        public int evilInnocent = +5;
        public EvilNPC()
        {
            npcStats[0] += evilyScary;
            npcStats[2] += evilInnocent;
        }
    }
}
