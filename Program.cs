using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepPlaying = true;
            while (keepPlaying)
            {
                GetOpponent();

            }
            Console.WriteLine("New Game? Y/N");
            ConsoleKeyInfo newGame = Console.ReadKey();
            keepPlaying = newGame.KeyChar == 'y';
        }
    }
}
