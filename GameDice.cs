using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    class GameDice : Game
    {
        Player PlayerOne;
        Player PlayerTwo;
        public void PlayDice()
        {
            //Header();
            //PlayOption();
            //GamePlay();
            //GameResults();
            //Footer();
        }
        public void Header()
        {
            string gameName = "Dice Game";
            Console.WriteLine("Welcome to {0}", gameName);
            Console.WriteLine("Who would you like to play today?");
            Console.WriteLine("Computer or Human?");
        }
        public void PlayOption()
        {
            //string OpponentOption = (Console.ReadLine());
            //switch (OpponentOption.ToLower())
            //{
            //    case "Human":
            //        Player playerOne = new PlayerOne();
            //        Player playerTwo = new PlayerTwo();
            //        break;

            //    case "Computer":
            //        Player PlayerOne = new PlayerOne();
            //        Computer Computer = new Computer();
            //        break;

            //    default:
            //        Console.WriteLine("Invalid selection. Please try again.");
            //        PlayOption();
            //        break;
            //}
            
        }
        public void GamePlay()
        {
            //string playerOneRoll();
            
        }
        public void GameResults()
        {
            //return ComputerPick;
        }
        public void Footer()
        {

        }
    }
}
