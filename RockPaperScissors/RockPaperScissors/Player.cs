using System;

namespace RockPaperScissors
{
    public class Player
    {
        public string halChoice;
        public string name;

        public Player ()
        {
            
        }
        public string GetPlayer()
        {
            Console.WriteLine("Please type in your move, 'rock', 'paper', 'scissors', 'lizard', 'spock'.");
            string userChoice = Console.ReadLine();
            if (userChoice == "rock")
            {
                Console.WriteLine("rock");
            }
            else if (userChoice == "paper")
            {
                Console.WriteLine("paper");
            }
            else if (userChoice == "scissors")
            {
                Console.WriteLine("scissors");
            }
            else if (userChoice == "lizzard")
            {
                Console.WriteLine("lizzard");
            }
            else if (userChoice == "spock")
            {
                Console.WriteLine("spock");
            }
            else
            {
                GetPlayer();
            }
            return userChoice;
        }
       
        public int PlayHAL()
        {
            Random choice = new Random();
            int halChoice = choice.Next(0, 5);
            if (this.halChoice = 1)
            {
                Console.WriteLine("rock");
            }
            else if (this.halChoice = 2)
            {
                Console.WriteLine("paper");
            }
            else if (this.halChoice = 3)
            {
                Console.WriteLine("scissors");
            }
            else if (this.halChoice = 4)
            {
                Console.WriteLine("lizzard");
            }
            else if (this.halChoice = 5)
            {
                Console.WriteLine("spock");
            }
            else
            {
                GetPlayer();
            }
            return halChoice;
        }
        //alternate way to get random selection
        //public int GetRandomNumber()
        //{
        //    int number = Random.Next (0,6)
        //    string [] halChoices = new string[5] { "rock", "paper", "scissors", "lizard", "spock"};

        //    return halChoices[number];
        //}
    }

    }

}