using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class Computer : Player
    {
        public override void GetPlayerName()
        {
            name = "HAL";
        }
        public override string GetPlayerChoice()
        {
            Random halChoice = new Random();
            int choice = halChoice.Next(1, 6);

            switch (choice)
            {
                case 1:
                    Console.WriteLine("HAL chose rock");
                    break;
                case 2:
                    Console.WriteLine("HAL chose paper");
                    break;
                case 3:
                    Console.WriteLine("HAL chose scissors");
                    break;
                case 4:
                    Console.WriteLine("HAL chose lizzard");
                    break;
                case 5:
                    Console.WriteLine("HAL chose spock");
                    break;
                default:
                    Console.WriteLine("There seems to be a glitch in my system");
                    break;
            }
        }
    }
}
   
