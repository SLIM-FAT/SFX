using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFX.Core
{
    internal class Player
    {
        public string name;
        public string type;
        public Player()
        {
            Console.WriteLine("Hello World!");
        }

        public void playerName(string name)
        {
            this.name = name;
        }

        public void playertype(string type)
        {
            this.type = type;
        }
    }
}
