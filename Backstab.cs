using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Backstab : Skill
    {
        public Backstab()
        {
            this.name = "Backstab";
        }
        public override void useSkill(Monster monster)
        {
            monster.setHealth(monster.getHealth() - 300);
            monster.setEnergy(monster.getEnergy() - 100);
        }
    }
}
