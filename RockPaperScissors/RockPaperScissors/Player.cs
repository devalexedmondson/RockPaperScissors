using System;

namespace RockPaperScissors
{
    public class Player
    {
        public string name;
        public string choice;

        public Player ()
        {
            
        }
        public virtual void GetPlayerName()
        {
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
        }
        public virtual string GetPlayerChoice()
        {
            Console.WriteLine("Please type in your move, 'rock', 'paper', 'scissors', 'lizard', 'spock'.");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "rock":
                    Console.WriteLine("Pass to next player");
                    break;
                case "paper":
                    Console.WriteLine("Pass to next player");
                    break;
                case "scissors":
                    Console.WriteLine("Pass to next player");
                    break;
                case "lizzard":
                    Console.WriteLine("Pass to next player");
                    break;
                case "spock":
                    Console.WriteLine("Pass to next player");
                    break;
                default:
                    Console.WriteLine("That doesnt seem to be an option");
                    break;
            }
            return choice;
        }

        public void TrackWins()
        {
            for (int rounds = 0; rounds < 3; rounds++)
            {
                GetPlayerChoice();
            }
        }
     
    }

    }