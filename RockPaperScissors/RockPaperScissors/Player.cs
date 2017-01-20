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
        public void GetPlayerName()
        {
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
        }
        public virtual void GetPlayerChoice()
        {
            Console.WriteLine("Please type in your move, 'rock', 'paper', 'scissors', 'lizard', 'spock'.");
            choice = Console.ReadLine();
            if (this.choice == "rock")
            {
                Console.WriteLine("rock");
            }
            else if (this.choice == "paper")
            {
                Console.WriteLine("paper");
            }
            else if (this.choice == "scissors")
            {
                Console.WriteLine("scissors");
            }
            else if (choice == "lizzard")
            {
                Console.WriteLine("lizzard");
            }
            else if (choice == "spock")
            {
                Console.WriteLine("spock");
            }
            else
            {
                GetPlayerChoice();
            }
        }
       
        //public int PlayHAL()
        //{
        //    Random choice = new Random();
        //    int halChoice = choice.Next(0, 5);
        //    if (this.halChoice = 1)
        //    {
        //        Console.WriteLine("rock");
        //    }
        //    else if (this.halChoice = 2)
        //    {
        //        Console.WriteLine("paper");
        //    }
        //    else if (this.halChoice = 3)
        //    {
        //        Console.WriteLine("scissors");
        //    }
        //    else if (this.halChoice = 4)
        //    {
        //        Console.WriteLine("lizzard");
        //    }
        //    else if (this.halChoice = 5)
        //    {
        //        Console.WriteLine("spock");
        //    }
        //    else
        //    {
        //        GetPlayerChoice();
        //    }
        //    return halChoice;
        //}
        //alternate way to get random selection
        //public int GetRandomNumber()
        //{
        //    int number = Random.Next (0,6)
        //    string [] halChoices = new string[5] { "rock", "paper", "scissors", "lizard", "spock"};

        //    return halChoices[number];
        //}
    }

    }

//}