﻿using System;
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
        public override void GetPlayerChoice()
        {
            Random halChoice = new Random();
            int choice = halChoice.Next(1, 6);

            Console.WriteLine(choice);

            switch (choice)
            {
                case 1:
                    Console.WriteLine("rock");
                    break;
                case 2:
                    Console.WriteLine("paper");
                    break;
                case 3:
                    Console.WriteLine("scissors");
                    break;
                case 4:
                    Console.WriteLine("lizzard");
                    break;
                case 5:
                    Console.WriteLine("spock");
                    break;
                default:
                    Console.WriteLine("There seems to be a glitch in my system");
                    break;
            }
        }
    }
    }
    //alternate way to get random selection
    //public int GetRandomNumber()
    //{
    //    int number = Random.Next (0,6)
    //    string [] halChoices = new string[5] { "rock", "paper", "scissors", "lizard", "spock"};

    //    return halChoices[number];
