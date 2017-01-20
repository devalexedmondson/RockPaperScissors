using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class TheGame
    {
        public Player playerOne;
        public Player playerTwo;
        public Computer computer; 

        public TheGame()
        {
            playerOne = new Player();
            playerTwo = new Player();
            computer = new Computer();
        }
        public void WelcomePlayer()
        {
            Console.WriteLine("Welcome to Rock-Paper-Scissors-Lizard-Spock!");
            Console.WriteLine("The rules of the game:\n Rock crushes Scissors and crushes Lizard\nPaper covers Rock and disproves Spock\nScissors cuts paper and decapitates Lizard\nLizard poisons Spock and eats Paper\nSpock smashes Scissors and vaporizes Rock");
        }
        //how many players

        public void PickAWinner()
        {
            if (playerOne = "rock" && playerTwo = "scissors" || playerTwo = "lizard")
            {
                Console.WriteLine("Player One Wins");
            }
            else if (playerOne = "paper" && playerTwo = "rock" || playerTwoC = "spock")
            {
                Console.WriteLine("Player One Wins");
            }
            else if (playerOne = "scissors" && playerTwo = "paper" || playerTwo = "lizard")
            {
                Console.WriteLine("Player One Wins");
            }
            else if (playerOne = "lizard" && playerTwo = "paper" || playerTwo = "spock")
            {
                Console.WriteLine("Player One Wins");
            }
            else if (playerOne = "spock" && playerTwo = "rock" || playerTwo = "scissors")
            {
                Console.WriteLine("Player One Wins");
            }
            else if (playerTwo = "rock" && playerOne = "scissors" || playerOne = "lizard")
            {
                Console.WriteLine("Player Two Wins");
            }
            else if (playerTwo = "paper" && playerOne = "rock" || playerOne = "spock")
            {
                Console.WriteLine("Player Two Wins");
            }
            else if (playerTwo = "scissors" && playerOne = "paper" || playerOne = "lizard")
            {
                Console.WriteLine("Player Two Wins");
            }
            else if (playerTwo = "lizard" && playerOne = "paper" || playerOne = "spock")
            {
                Console.WriteLine("Player Two Wins");
            }
            else if (playerTwo = "spock" && playerOne = "rock" || playerOne = "scissors")
            {
                Console.WriteLine("Player Two Wins");
            }

            else
            {
                Console.WriteLine("Not a choice");
            }
        }

        //way to use algorithm to get player options
        List<string> choices = new List<string>() { "rock", "paper", "scissors", "lizard", "spock" };
   
        public void TrackWin()
        {
            
        }
        public void TrackRound()
        {
          
        }
        

    }
}

//create 2 player functionality and finish by 1/20/17