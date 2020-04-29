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
        //Precis som i friendlyNPC, olika ints som är plus eller minus
        public EvilNPC()
        {
            //Som sedan läggs till här i sin respektive stat
            npcStats[0] += evilyScary;
            npcStats[2] += evilInnocent;
        }
    }
}
