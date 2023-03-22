using System;
using System.Text;

namespace Project
{
    class Monster : BasePerson
    {
        protected int damage;
        protected int armor;
        protected int experiencePointsToPlayer;
        public Monster(string name, int level) : base(name, level)
        {
            this.health = level * 100;
            this.damage = level * 10;
            this.armor = level * 5;
            this.experiencePointsToPlayer = level * 50;
        }
        public int getDamage() => this.damage;
        public int getArmor() => this.armor;
        public int getExperiencePointsToPlayer() => this.experiencePointsToPlayer;
    }
}
