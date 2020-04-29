using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slutprojekt2020
{
    class Program
    {



        static void Main(string[] args)
        {

            //INKAPSLING
            //KOMMENTARER
            //Polymorfism            
            //TEXTBASERAT UTFORSKNINGSSPEL



            string playerChoice = "";
            int[] playerStats = Introduction(0, 0, 0);
            //Detta är min array som innehåller spelarens data gällande dess stats.

            Console.WriteLine("Your scariness is: " + playerStats[0]);
            Console.WriteLine("Your handsomeness is: " + playerStats[1]);
            Console.WriteLine("Your inoccence is: " + playerStats[2]);
            //Detta visar spelaren vad den har valt för stats, alltså hur mycket poäng den har investerat i varje stat. Skulle kunna försöka ha detta på display permanent eller ge spelaren
            //ett alternativ att visa dessa när som helst.
            Console.ReadLine();

            Console.Clear();
            Console.WriteLine("You find yourself at the entrance of a large building. You have avague memory of what you're supposed to do: ");
            Console.WriteLine("Go to the Resonating Chamber");
            Console.WriteLine("Bla bla bla dangerous");
            Console.WriteLine("Find the Dodecahedron");
            Console.WriteLine("Bla bla bla bending reality");
            Console.WriteLine("Come back, get paid. Easy enough.");
            //Detta är en lore beskrivning men också en uppgiftsbeskrvningen av vad spelaren ska göra i detta program.
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("You enter the cave, and find yourself in a kind of... room. Almost like it was designed to be a chamber.");
            Console.WriteLine("In this room you see a person, stadning behin a desk of some sort, waving you over.");
            //Det här skulle vara den första beskrivningen av ett encounter, men är även en text som jag kunde haft i encounter processen eller randomiserat.
            System.Threading.Thread.Sleep(2000);
            Console.Clear();
            NPC steve = new FriendlyNPC();
            //Här skapar jag en ny friendlyNPC som är en NPC.
            steve.GenerateStats();
            //Den här metoden tar NPC:en och generarar dens stats så att den har något att jämnföra mot spelarens.
            Console.WriteLine("He says he has information about the Dodecahedron, but isn't willing to just give it up. How do you convince him?");
            Console.WriteLine("");
            Console.WriteLine("Threaten him (scariness: "+playerStats[0]+")");
            Console.WriteLine("Flirt a little (handsomness: "+playerStats[1]+")");
            Console.WriteLine("Ask him to tell you a story about the cool magic object!(Innocence: "+playerStats[2]+")");
            //Här är spealrens val av hur den ska övertala NPC:en och valet om vilken stat den vill använda.
            playerChoice = Console.ReadLine();
            //Spelarens svar sparas som playerChoice, som ör skapad sedan tidigare.


        }
        static int[] Introduction(int playerScaryValue, int playerHandsomeValue, int playerInnocentValue)
        {
            int pointsToSpend = 42;
            //En int för spelarens mängd poäng som den har att spendera skapas först.

            Console.WriteLine("Hello there player! Welcome to Generic Dungeon Delver, GDD for short!");
            Console.WriteLine("In GDD, your objective is to search through rooms and talk to individuals in order to find the exit.");
            Console.WriteLine("Before you start the game, you can choose how handsome, scary and innocent you look.");
            //Beskriver vad syftet med denna metod är. Att spendera poäng för att avgöra hur mycket poäng varje stat har.
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Please pick your respective scores by entering the number of points you want in that skill.");
            Console.WriteLine("The higher the score, the higher chance of success. The limit is 20 on a single score.");
            //Här beskrivs de gränser som spelaren har när den spenderar poäng.
            while (pointsToSpend > 1)
            {

                Console.WriteLine("Choose skillpoints in scary, between 1 and 20. You have "+pointsToSpend+" points to spend."); 
                //Restriktionerna upprepas varje gång spelaren ska välja ett värde för de poäng som den vill spendera.
                string playersScary = Console.ReadLine();
                //Den här stringen behövs bara här, så den skapas och fylls av det som spelaren väljer som värde.
                bool success = int.TryParse(playersScary, out playerScaryValue);
                //Här kollas det om det faktiskt är ett tal som kan göras om till en int.
                if (success == true)
                {
                    //Den här gör om den till en int, ifall att den kan göras om till en int tidigare.
                    playerScaryValue = int.Parse(playersScary);
                }
                if (playerScaryValue < 1)
                {
                    Console.WriteLine("Value adjusted to within the paramteters.");
                    //
                    playerScaryValue = 1;
                }
                else if (playerScaryValue > 20 )
                {
                    Console.WriteLine("Value adjusted to within the paramteters.");
                    //
                    playerScaryValue = 20;

                }
                else if (playerScaryValue > pointsToSpend)
                {
                    Console.WriteLine("Value adjusted to within the paramteters.");
                    //
                    playerScaryValue = pointsToSpend;
                }
                //Alla dessa if och else if satser kollar vad värdet är och genom detta ändrar värdet till inom de parametrar.
                pointsToSpend -= playerScaryValue;
                Console.WriteLine("Points remaning: "+pointsToSpend);
                //Här skrivs även ut hur många poäng som återstår för att spendera på andra värden. 
                Console.ReadLine();
                //Denna process repeteras sedan två gånger till, för att bestämma de andra två värden med deras egna strings och ints. 


                Console.WriteLine("Choose skillpoints in handsome, between 1 and "+pointsToSpend+".");
                string playersHandsome = Console.ReadLine();
                success = int.TryParse(playersHandsome, out playerHandsomeValue);
                if (success == true)
                {
                    //
                    playerHandsomeValue = int.Parse(playersHandsome);
                }
                if (playerHandsomeValue < 1)
                {
                    Console.WriteLine("Value adjusted to within the paramteters.");
                    //
                    playerHandsomeValue = 1;
                }
                else if (playerHandsomeValue > 20)
                {
                    Console.WriteLine("Value adjusted to within the paramteters.");
                    //
                    playerHandsomeValue = 20;

                }
                else if (playerHandsomeValue > pointsToSpend)
                {
                    Console.WriteLine("Value adjusted to within the paramteters.");
                    //
                    playerHandsomeValue = pointsToSpend;
                }
                pointsToSpend -= playerHandsomeValue;
                Console.WriteLine("Points remaning: " + pointsToSpend);
                Console.ReadLine();



                Console.WriteLine("Choose skillpoints in innocent, between 1 and " + pointsToSpend + ".");
                string playersInnocent = Console.ReadLine();
                success = int.TryParse(playersInnocent, out playerInnocentValue);
                if (success == true)
                {
                    //
                    playerInnocentValue = int.Parse(playersInnocent);
                }
                if (playerInnocentValue < 1)
                {
                    Console.WriteLine("Value adjusted to within the paramteters.");
                    //
                    playerInnocentValue = 1;
                }
                else if (playerInnocentValue > 20)
                {
                    Console.WriteLine("Value adjusted to within the paramteters.");
                    //
                    playerInnocentValue = 20;

                }
                else if (playerInnocentValue > pointsToSpend)
                {
                    Console.WriteLine("Value adjusted to within the paramteters.");
                    //
                    playerInnocentValue = pointsToSpend;
                }
                pointsToSpend -= playerInnocentValue;
                Console.WriteLine("Points remaning: " + pointsToSpend);
                Console.ReadLine();
                return new int[3] { playerScaryValue, playerHandsomeValue, playerInnocentValue };
                //Här returneras de tre värden som spelaren har valt eller fått på grund av paramterarna.
            }
            return new int[1] { 0 };
           
        }
        //static int[] EmptyRoom()
        //{

        //}
    }
}
