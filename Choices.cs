using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{

    public class Choices
    {
        public int rock = 0;
        public int paper = 1;
        public int scissors = 2;
        public int lizard = 3;
        public int spock = 4;
    }
    public int pickEquation(int GetHumanPick, int GetComputerPick)
    {
        pickEquation = (5 + GetHumanPick - GetComputerPick) % 5;
        return pickEquation;
    }
    public string pickResult()
    {
        if (pickEquation == 1 || 3)
            Console.WriteLine("Win");

        else if (pickEquation == 2 || 4)
            Console.WriteLine("Lose");

        else if (pickEquation == 0)
            Console.WriteLine("Tie");
    }
}
