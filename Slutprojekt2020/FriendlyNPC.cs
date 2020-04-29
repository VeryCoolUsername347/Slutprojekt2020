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
        //Plus eller minus på int värden som jag har i NPC
        //Sen en instans av FriendöyNPC som räknar ut den slutgiltiga värdet för dens stats
        public FriendlyNPC()
        {
            npcStats[0] += friendlyScary;
            npcStats[2] += friendlyInnocent;

            //En for loop som skulle skriva ut alla stats i en form utav "Printout" metod om spelaren hade tillräckligt med "insigt" som jag inte lagt till
            //for (int i = 0; i < npcStats.Length; i++)
            //{

            //}
        }
    }
}
