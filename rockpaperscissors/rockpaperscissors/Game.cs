using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class Game
    {
        public Player playerOne;
        public Player playerTwo;

        public Game()
        {
            
        }
        public void RunGame()
        {
            WelcomePlayer();
            PickPlayers();
            playerOne.GetPlayerName();
            playerTwo.GetPlayerName();
            string choiceOne = playerOne.GetPlayerChoice();
            string choiceTwo = playerTwo.GetPlayerChoice();
            string roundwinner = PickAWinner();
            
        }

        //public void TrackWins()
        //{
        //    for (int wins = 0; wins < 3; wins++)
        //    {
        //        GetPlayerChoice();
        //    }
        //}
        public void WelcomePlayer()
        {
            Console.WriteLine("Welcome to Rock-Paper-Scissors-Lizard-Spock!");
            Console.WriteLine("The rules of the game:\nRock crushes Scissors and crushes Lizard\n\nPaper covers Rock and disproves Spock\n\nScissors cuts paper and decapitates Lizard\n\nLizard poisons Spock and eats Paper\n\nSpock smashes Scissors and vaporizes Rock\n");
        }
        public string PickPlayers()
        {
            Console.WriteLine("How many people will be playing, '1' or '2'?");
            string userInput = Console.ReadLine();
                if (userInput == "1")
                {
                playerOne = new Human();
                playerTwo = new Computer();
                }
                else if (userInput == "2")
                {
                playerOne = new Human();
                playerTwo = new Human();
                }
                else
                {
                Console.WriteLine("I dont think you understood the question...");
                     PickPlayers();
                }
            return userInput;
        }
        public string PickAWinner()
        {
            string winner = "";

            if (playerOne.choice == "rock" && playerTwo.choice == "scissors" || playerTwo.choice == "lizard")
            {
                Console.WriteLine($"{playerOne.name}, Wins!");
            }
            else if (playerOne.choice == "paper" && playerTwo.choice == "rock" || playerTwo.choice == "spock")
            {
                Console.WriteLine($"{playerOne.name}, Wins!");
            }
            else if (playerOne.choice == "scissors" && playerTwo.choice == "paper" || playerTwo.choice == "lizard")
            {
                Console.WriteLine($"{playerOne.name}, Wins!");
            }
            else if (playerOne.choice == "lizard" && playerTwo.choice == "paper" || playerTwo.choice == "spock")
            {
                Console.WriteLine($"{playerOne.name}, Wins!");
            }
            else if (playerOne.choice == "spock" && playerTwo.choice == "rock" || playerTwo.choice == "scissors")
            {
                Console.WriteLine($"{playerOne.name}, Wins!");
            }
            else if (playerTwo.choice == "rock" && playerOne.choice == "scissors" || playerOne.choice == "lizard")
            {
                Console.WriteLine($"{playerTwo.name}, Wins!");
            }
            else if (playerTwo.choice == "paper" && playerOne.choice == "rock" || playerOne.choice == "spock")
            {
                Console.WriteLine($"{playerTwo.name}, Wins!");
            }
            else if (playerTwo.choice == "scissors" && playerOne.choice == "paper" || playerOne.choice == "lizard")
            {
                Console.WriteLine($"{playerTwo.name}, Wins!");
            }
            else if (playerTwo.choice == "lizard" && playerOne.choice == "paper" || playerOne.choice == "spock")
            {
                Console.WriteLine($"{playerTwo.name}, Wins!");
            }
            else if (playerTwo.choice == "spock" && playerOne.choice == "rock" || playerOne.choice == "scissors")
            {
                Console.WriteLine($"{playerTwo.name}, Wins!");
            }
            else
            {
                Console.WriteLine("It's a draw!");
            }
            return winner;
        }
       
        public void TrackRound()
        {
            for (int rounds = 0; rounds < 3; rounds++)
            {
                playerOne.GetPlayerChoice();
            }
        }
    }
}