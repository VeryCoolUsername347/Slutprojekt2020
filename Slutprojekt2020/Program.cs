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

            NPC steve = new FriendlyNPC();
            steve.GenerateStats();


            int[] playerStats = Introduction(0, 0, 0);

            Console.WriteLine("Your scariness is: " + playerStats[0]);
            Console.WriteLine("Your handsomeness is: " + playerStats[1]);
            Console.WriteLine("Your inoccence is: " + playerStats[2]);
            Console.ReadLine();

            Console.Clear();
            Console.WriteLine("You find yourself at the entrance of a large building. You have avague memory of what you're supposed to do: ");
            Console.WriteLine("Go to the Resonating Chamber");
            Console.WriteLine("Bla bla bla dangerous");
            Console.WriteLine("Find the Dodecahedron");
            Console.WriteLine("Bla bla bla bending reality");
            Console.WriteLine("Come back, get paid. Easy enough.");



        }
        static int[] Introduction(int playerScaryValue, int playerHandsomeValue, int playerInnocentValue)
        {
            int pointsToSpend = 42;


            Console.WriteLine("Hello there player! Welcome to Generic Dungeon Delver, GDD for short!");
            Console.WriteLine("In GDD, your objective is to search through rooms and talk to individuals in order to find the exit.");
            Console.WriteLine("Before you start the game, you can choose how handsome, scary and innocent you look.");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Please pick your respective scores by entering the number of points you want in that skill.");
            Console.WriteLine("The higher the score, the higher chance of success. The limit is 20 on a single score.");
            while (pointsToSpend > 1)
            {

                Console.WriteLine("Choose skillpoints in scary, between 1 and 20. You have "+pointsToSpend+" points to spend."); 
                string playersScary = Console.ReadLine();
                bool success = int.TryParse(playersScary, out playerScaryValue);
                if (success == true)
                {
                    //
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
                pointsToSpend -= playerScaryValue;
                Console.WriteLine("Points remaning: "+pointsToSpend);
                Console.ReadLine();



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
            }
            return new int[1] { 0 };
           
        }
    }
}
