using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    public class PlayerTwo : Player
    {
        public int PlayerTwoScore = 0;

        public PlayerTwo (string PlayerTwoName, int PlayerTwoScore)
            //: base (PlayerTwoName, PlayerScore)
        {
            Console.WriteLine("What is your name?");
            string PlayerName = Console.ReadLine();
            PlayerName = PlayerTwoName;
            PlayerScore = PlayerTwoScore;
        }
    }
}
