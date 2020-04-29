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
        //Här skapas en array men ints som innehåller 3 platser för mina 3 stats

        public void GenerateStats()
        {
            //Här är metoden som generar stats genom en random generator i en for loop för så många gånger som npcStats är lång (alltså 3 om inte min matte är fel)
            Random generator = new Random();
            for (int i = 0; i < npcStats.Length; i++)
            {
                npcStats[i] = generator.Next(1, 21);
            }
            
        }
        public bool PlayerUsesScary(int playerValue)
        {
            //Det här är påbörjan på en metod nnär en spelare försöker använda Scary för att skrämma en NPC. Går att optimisera för alla stats istället för ett enda, men basically
            //en metod som innefattar spelarens chans att lyckas, spelarens val av förmåga och vare sig den lyckas eller inte.
            bool playerWin = true;
            
            if (true)
            {

            }
            return playerWin;
        }
        public bool PlayerUsesHandsome(int playerValue)
        {
            bool playerWin = true;
            return playerWin;
        }
        public bool PlayerUsesInnocent(int playerValue)
        {
            bool playerWin = true;

            return playerWin;
        }
    }
}
