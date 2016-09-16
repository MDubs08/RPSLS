using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Computer : Player
    {
        public int GetComputerPick;
        public string choice;
        public Computer()
        {
            name = "Computer";
        }
        public int ComputerPick()
        {
        Random computerPick = new Random();
        int GetComputerPick = computerPick.Next(1, 6);
        return (GetComputerPick);
        }
    }
}

