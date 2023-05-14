using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFX
{
    internal class Player
    {
        public String name;
        public String type;
        public Player()
        {
            Console.WriteLine("Hello World!");
        }

        public void playerName(String name)
        {
            this.name = name;
        }

        public void playertype(String type)
        {
            this.type = type;
        }
    }
}
