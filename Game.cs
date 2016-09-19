using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    class Game
    {
        GameDice PlayDice;
        GameRPSLS PlayRPSLS;
        public void GameSelector()
        {
            SelectorHeader();
            GameOption();
        }
        public void SelectorHeader()
        {
            Console.WriteLine("Welcome to i++");
            Console.WriteLine("The two game test machine");

        }
        public void GameOption()
        {
            Console.WriteLine("Choose a game to play.");
            Console.WriteLine("Dice or RPSLS?");
            string gameOption = Console.ReadLine();
            switch (gameOption.ToLower())
            {
                case "dice":
                    Console.WriteLine("Dice is unavailable at this time.");
                    //Game diceGame = new GameDice();
                    GameOption();
                    break;


                case "rpsls":
                    GameRPSLS game = new GameRPSLS();
                    game.PlayRPSLS();
                    break;

                default:
                    Console.WriteLine("Invalid selection. Please try again.");
                    GameOption();
                    break;
            }
        }
    }
}
