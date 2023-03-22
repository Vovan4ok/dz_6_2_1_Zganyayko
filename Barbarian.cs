using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Barbarian : Player
    {
        public Barbarian(string name) : base(name)
        {
            this.power = 15;
            this.endurance = 15;
            this.agility = 10;
        }
    }
}
