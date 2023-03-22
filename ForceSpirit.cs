using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class ForceSpirit : Skill
    {
        public ForceSpirit()
        {
            this.name = "Force Spirit";
        }
        public override void useSkill(Monster monster)
        {
            monster.setHealth(monster.getHealth() - 100);
        }
    }
}
