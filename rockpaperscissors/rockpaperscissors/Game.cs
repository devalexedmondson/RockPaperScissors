using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class TheGame
    {
        Player playerOne;
        Player playerTwo;

        public TheGame()
        {
            playerOne = new Player();
            playerTwo = new Player();
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
            
            }
            else
            {
                WelcomePlayer();
            }
             return userInput; 
        }
        public void PickAWinner()
        {
            if (playerOneChoice = "rock" && playerTwoChoice = "scissors" || playerTwoChoice = "lizard")
            {
                Console.WriteLine("Player One Wins");
            }
            else if (playerOneChoice = "paper" && playerTwoChoice = "rock" || playerTwoChoice = "spock")
            {
                Console.WriteLine("Player One Wins");
            }
            else if (playerOneChoice = "scissors" && playerTwoChoice = "paper" || playerTwoChoice = "lizard")
            {
                Console.WriteLine("Player One Wins");
            }
            else if (playerOneChoice = "lizard" && playerTwoChoice = "paper" || playerTwoChoice = "spock")
            {
                Console.WriteLine("Player One Wins");
            }
            else if (playerOneChoice = "spock" && playerTwoChoice = "rock" || playerTwoChoice = "scissors")
            {
                Console.WriteLine("Player One Wins");
            }
            else if (playerTwoChoice = "rock" && playerOneChoice = "scissors" || playerOneChoice = "lizard")
            {
                Console.WriteLine("Player Two Wins");
            }
            else if (playerTwoChoice = "paper" && playerOneChoice = "rock" || playerOneChoice = "spock")
            {
                Console.WriteLine("Player Two Wins");
            }
            else if (playerTwoChoice = "scissors" && playerOneChoice = "paper" || playerOneChoice = "lizard")
            {
                Console.WriteLine("Player Two Wins");
            }
            else if (playerTwoChoice = "lizard" && playerOneChoice = "paper" || playerOneChoice = "spock")
            {
                Console.WriteLine("Player Two Wins");
            }
            else if (playerTwoChoice = "spock" && playerOneChoice = "rock" || playerOneChoice = "scissors")
            {
                Console.WriteLine("Player Two Wins");
            }

            else
            {
                Console.WriteLine("Not a choice");
            }
        }

        public void TrackWin()
        {
            
        }
        public void TrackRound()
        {
          
        }
        

    }
}

//create 2 player functionality and finish by 1/20/17