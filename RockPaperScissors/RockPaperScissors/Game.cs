using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class Game
    {
        Player playerOne;
        Player playerTwo;

        public Game()
        {
            playerOne = new Player();
            playerTwo = new Player();
        }
    public void RunGame()
        {
            
            WelcomePlayer();
            if (WelcomePlayer() == "1")
            {
                GetPlayerOption();
            }
            else if (WelcomePlayer() == "2")
            {
                playerOne.choice = GetPlayerOption();
                playerTwo.choice = GetPlayerOption();
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
                GetPlayerOption();
                GetPlayerOption();
                
                //if (player one wins == true)
                //{
                //    run method that displays player one wins!
                //}
                //else if (player two wins == true)
                //{
                //    run method that displays player two wins!
                //}
                //else 
                //{
                //    do i need an else? if no else needed then change else if to else
                //}
            }
            else
            {
                WelcomePlayer();
            }
             return userInput; 
        }
        public string GetPlayerOption()
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
                GetPlayerOption();
            }
            return userInput;
        }

        

    }
}

//create 2 player functionality and finish by 1/20/17