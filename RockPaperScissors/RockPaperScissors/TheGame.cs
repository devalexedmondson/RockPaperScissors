using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class TheGame
    {
        public string WelcomePlayer()
        {
            int numberOfPlayers;
            Console.WriteLine("Welcome to Rock-Paper-Scissors-Lizard-Spock!");
            Console.WriteLine("How many players are there, '1' or '2'?");
            string userInput = Console.ReadLine();            
            if (userInput == "1")
            {
                //Go to player vs AI prompt
            }
            else if (userInput == "2")
            {
                //Go to player vs player prompt
            }
            else
            {
                WelcomePlayer();
            }
             //return numberOfPlayers;
        }

        
    }
}

//create 2 player functionality and finish by 1/20/17