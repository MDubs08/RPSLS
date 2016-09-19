using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    public class PlayerOne : Player
    {
        public int PlayerOneScore = 0;
        int correct = 0;
        int rock = 1;
        int paper = 2;
        int scissors = 3;
        int lizard = 4;
        int spock = 5;
        public PlayerOne(string PlayerOneName, int PlayerOneScore)
            //: base(PlayerOneName, PlayerScore)
        {
            Console.WriteLine("What is your name?");
            string PlayerName = Console.ReadLine();
            PlayerName = PlayerOneName;
            PlayerScore = PlayerOneScore;
        }
        public void PlayerOneSelection()
        {
            int Choice = 0;
            do
            {
                Console.WriteLine("{0}'s turn. Please choose one of the following options: ", PlayerName);
                Console.WriteLine("Rock, Paper, Scissors, Lizard, Spock");
                Choice = Convert.ToInt32(Console.ReadLine().ToLower());
                if (Choice == rock || Choice == paper || Choice == scissors || Choice == lizard || Choice == spock)
                {
                    correct = 1;
                    Console.WriteLine(Choice);
                    Choice++;
                }
                else
                {
                    Console.WriteLine("Invalid selection. Please try again");
                    Selection();
                }
            } while (Choice < 6);
            while (correct == 0) ;

        }
    }
}
