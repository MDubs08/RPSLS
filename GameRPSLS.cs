using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    class GameRPSLS : Game
    {
        //Player PlayerOne;
        //Player PlayerTwo;
        public void PlayRPSLS()
        {
            Header();
            PlayOption();
            //GamePlay();
            GameResults();
            Footer();
        }
        public string Header()
        {
            string gameName = "Rock, Paper, Scissors, Lizard, Spock";
            Console.WriteLine("Welcome to {0}", gameName);
            return gameName;
        }
        public void PlayOption()
        {
            Console.WriteLine("Who would you like to play today?");
            Console.WriteLine("Computer or Human?");

            string OpponentOption = Console.ReadLine();
            switch (OpponentOption.ToLower())
            {
                case "human":
                    PlayerOne playerOne = new PlayerOne("PlayerOne",0);
                    PlayerTwo playerTwo = new PlayerTwo("PlayerTwo",0);
                    break;

                case "computer":
                    PlayerOne PlayerOne = new PlayerOne("PlayerOne",0);
                    Computer Computer = new Computer("Computer",0);
                    break;

                default:
                    Console.WriteLine("Invalid selection. Please try again.");
                    PlayOption();
                    break;
            }
        }
        //public void GamePlay()
        //{

        //    do
        //    {
        //        Console.WriteLine:("{0} Picks {1}" , PlayerName, PlayerSelection);
        //        if OpponentOption = { OpponentOption == "human"}
        //    }



        //}
        public void GameResults()
        {
            //if results = (5 + PlayerChoice - Computerchoice) % 5
        }
        public void Footer()
        {
            //PlayAgain = 0;
            //do
            {
                string gameName = "Rock, Paper, Scissors, Lizard, Spock";
                Console.WriteLine("Thank you for playing {0}", gameName);
                Console.WriteLine("Would you like to play again? Y/N?");
                //    PlayAgain = Console.ReadLine().ToLower();
                //    if PlayAgain = { PlayAgain == "y"}
                //    {
                //        correct = 1;
                //    }
                //    else if { PlayAgain == "n"}
                //    {
                //        correct = 2;
                //    }
                //    else{ }
                //} while (PlayAgain == 0);
                //while correct = 0;

                Console.ReadLine();
            }
        }
    }
}
