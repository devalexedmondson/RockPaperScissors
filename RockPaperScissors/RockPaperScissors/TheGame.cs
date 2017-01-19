using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class TheGame
    {
        public void RunGame()
        {

        }
        public void WelcomePlayer()
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
                PlayerOneOptions();
            }
            else
            {
                WelcomePlayer();
            }
             //return numberOfPlayers; (maybe return?) 
        }
        public string PlayerOneOptions()
        {
            Console.WriteLine("Player one, please type in your move, 'rock', 'paper', 'scissors', 'lizard', 'spock'.");
            string userInput = Console.ReadLine(); 
            if (userInput == "rock")
            {
                Console.WriteLine("rock");
            }
            else if (userInput == "paper")
            {
                Console.WriteLine("paper");
            }
            else if (userInput == "scissors")
            {
                Console.WriteLine("scissors");
            }
            else if (userInput == "lizzard")
            {
                Console.WriteLine("lizzard");
            }
            else if (userInput == "spock")
            {
                Console.WriteLine("spock");
            }
            else
            {
                PlayerOneOptions();
            }
            return userInput;
        }

        public string PlayerTwoOptions()
        {
            Console.WriteLine("Player one, please type in your move, 'rock', 'paper', 'scissors', 'lizard', 'spock'.");
            string userInput = Console.ReadLine();
            if (userInput == "rock")
            {
                Console.WriteLine("rock");
            }
            else if (userInput == "paper")
            {
                Console.WriteLine("paper");
            }
            else if (userInput == "scissors")
            {
                Console.WriteLine("scissors");
            }
            else if (userInput == "lizzard")
            {
                Console.WriteLine("lizzard");
            }
            else if (userInput == "spock")
            {
                Console.WriteLine("spock");
            }
            else
            {
                PlayerTwoOptions();
            }
            return userInput;
        }

    }
}

//create 2 player functionality and finish by 1/20/17