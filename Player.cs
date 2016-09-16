using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Player
    {
        public string name { get; set; }
        public int pick;
        public Player()
        {
        
        }
        public void PlayerPick()
        {
            Console.WriteLine("{0) picked {1}", name, pick);
        }
    }
}
