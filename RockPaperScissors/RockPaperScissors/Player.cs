using System;

namespace RockPaperScissors
{
    public class Player
    {
        public string choice;
        public string name;


        public string GetPlayerOption()
        {
            Console.WriteLine("Please type in your move, 'rock', 'paper', 'scissors', 'lizard', 'spock'.");
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