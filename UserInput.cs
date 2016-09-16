using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class UserInput
    {
        public string GetOpponent()
        {
            Console.WriteLine("Welcome to RPSLS!");
            Console.WriteLine("Who would you like to battle today?");
            Console.WriteLine("Another Human or the Computer?");
            string opponent = Console.ReadLine();
            switch (opponent.ToLower())
            {
                case "human":
                    Player human = new Human();
                    GetHumanPick();
                    GetHumanPick();
                    break;

                case "computer":
                    Player computer = new Computer();
                    GetHumanPick();
                    GetComputerPick();
                    break;

                default:
                    Console.WriteLine("Invalid Selection. Please try again.");
                    break;
            }
        }
        public int GetHumanPick()
        {
            Console.WriteLine("Please enter one of the following: ");
            Console.WriteLine("Rock, Paper, Scissors, Lizard, Spock");
            string input = Console.ReadLine();
            return Convert.ToInt32(input);
        }

    }
}
