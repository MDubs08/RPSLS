using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    public class Computer : Player
    {
        int ComputerScore = 0;
        string ComputerName = "Computer";

        public Computer(string ComputerName, int ComputerScore)
        {
            PlayerScore = ComputerScore;
        }
        public int ComputerPick()
        {
            Random computerPick = new Random();
            int GetComputerPick = computerPick.Next(1, 6);
            return (GetComputerPick);
        }
    }

}
