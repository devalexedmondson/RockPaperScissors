using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Reference
    {
        public bool StartGame()
        {
            bool continueStory = false;
            Console.WriteLine("You were born, do you want to continue?");
            Console.WriteLine("'yes' or 'no'");
            string userInput = Console.ReadLine();
            if (userInput == "yes")
            {
                continueStory = true;
            }
            return continueStory;
        }
        public bool PickAChildhood()
        {
            bool goThroughPuberty = false;
            Console.WriteLine("You graduate highschool, would you like to go to college? 'yes' or 'no'");
            Console.WriteLine("'yes' or 'no'");
            string userInput = Console.ReadLine();
            if (userInput == "yes")
            {
                return true;
            }
            return goThroughPuberty;
        }

        public void AdultLife()
        {
            Console.WriteLine("Congrats, you graduated college and are now deeply in debt");
            Console.WriteLine("What do you want to do, get a 'job', live at 'home', or 'travel'?");
            string adultChoice = Console.ReadLine();

            switch (adultChoice)
            {
                case "job":
                    GetAJob();
                    GetPressured();
                    break;
                case "home":
                    LiveAtHome();
                    break;
                case "travel":
                    TravelTheWorld();
                    break;
                default:
                    Console.WriteLine("You do nothing, you sit there....forever. GameOver.");
                    break;
            }
        }
        public void GetAJob()
        {
            Console.WriteLine("Congrats! You get a job meet the love of your life. \n");
        }
        public void GetPressured()
        {
            Console.WriteLine("You have been dating your girlfriend/boyfriend for a year now. They say that this is way too long and says that you two should get married, what do you do? \n");
            Console.WriteLine("'Purpose', 'break up', 'stall'");
            string userImput = Console.ReadLine().ToLower();

            if (userImput == "purpose")
            {
                LiveTheMarriedLife();
            }
            else if (userImput == "break up")
            {
                LiveTheFreeLife();
            }
            else if (userImput == "stall")
            {
                LiveInLimbo();
            }
            else
            {
                GameOver();
            }
        }
        private void LiveTheMarriedLife()
        {
            Console.WriteLine("You are now married....Game Over: You die.");
        }
        private void LiveTheFreeLife()
        {
            Console.WriteLine("After finding out that the love of your life is crazy, you break up with them and live a very long successful life.");
            Console.WriteLine("You Win!");
        }
        private void LiveInLimbo()
        {
            Console.WriteLine("You deflect the question and live to fight another day. Two months later you find out your girlfriend/boyfriend is cheating on you.");
            Console.WriteLine("You are devastated by the new and go into a deep depression. Game Over: You Die");
        }


        public void LiveAtHome()
        {
            Console.WriteLine("You live out the rest of your days in your parents basement and live a very sad life");
        }

        public void TravelTheWorld()
        {
            Console.WriteLine("You travel to South America and end up getting kidnapped");
        }
        public void GameOver()
        {
            Console.WriteLine("You died: Game over");
        }

        public void RunGame()
        {
            bool startGameResponse = StartGame();
            if (startGameResponse)
            {
                bool pickChildhoodResponse = PickAChildhood();
                if (pickChildhoodResponse)
                {
                    AdultLife();
                }
                else
                {
                    GameOver();
                }
            }
            else
            {
                GameOver();
            }


        }

    
}
}
