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
            WelcomePlayer();
            if (WelcomePlayer() == "1")
            {
                PlayerOneOptions();
            }
            else if (WelcomePlayer() == "2")
            {
                string playerOneChoice = PlayerOneOptions();
                string playerTwoChoice = PlayerTwoOptions();
            }
            else
            {
                WelcomePlayer();
            }

        }
        public string WelcomePlayer()
        {
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
             return userInput; 
        }
        public string PlayerOneOptions()
        {
            Console.WriteLine("Player one, please type in your move, 'rock', 'paper', 'scissors', 'lizard', 'spock'.");
            string playerOneChoice = Console.ReadLine(); 
            if (playerOneChoice == "rock")
            {
                Console.WriteLine("rock");
            }
            else if (playerOneChoice == "paper")
            {
                Console.WriteLine("paper");
            }
            else if (playerOneChoice == "scissors")
            {
                Console.WriteLine("scissors");
            }
            else if (playerOneChoice == "lizzard")
            {
                Console.WriteLine("lizzard");
            }
            else if (playerOneChoice == "spock")
            {
                Console.WriteLine("spock");
            }
            else
            {
                PlayerOneOptions();
            }
            return playerOneChoice;
        }

        public string PlayerTwoOptions()
        {
            Console.WriteLine("Player one, please type in your move, 'rock', 'paper', 'scissors', 'lizard', 'spock'.");
            string playerTwoChoice = Console.ReadLine();
            if (playerTwoChoice == "rock")
            {
                Console.WriteLine("rock");
            }
            else if (playerTwoChoice == "paper")
            {
                Console.WriteLine("paper");
            }
            else if (playerTwoChoice == "scissors")
            {
                Console.WriteLine("scissors");
            }
            else if (playerTwoChoice == "lizzard")
            {
                Console.WriteLine("lizzard");
            }
            else if (playerTwoChoice == "spock")
            {
                Console.WriteLine("spock");
            }
            else
            {
                PlayerTwoOptions();
            }
            return playerTwoChoice;
        }

    }
}

//create 2 player functionality and finish by 1/20/17