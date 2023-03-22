using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Player : BasePerson
    {
        protected int power;
        protected int agility;
        protected int endurance;
        protected int experiencePoints;
        protected Shield shield;
        protected Weapon weapon;
        protected List<Skill> skills;
        public Player() : base() { }
        public Player(string name) : base(name, 1)
        {
            this.health = 1000;
            this.healthMax = 1000;
            this.skills = new List<Skill>();
        }
        public void setWeapon(Weapon weapon) => this.weapon = weapon;
        public Weapon getWeapon() => this.weapon;
        public void addSkill(Skill skill)
        {
            this.skills.Add(skill);
        }
        public void printSkills()
        {
            int i = 0;
            Console.WriteLine("Список скілів!!");
            foreach (var skill in this.skills)
            {
                Console.WriteLine($"{i} - {skill.getName()}");
            }
        }
        public void useSkills(int index, Monster monster)
        {
            this.skills[index].useSkill(monster);
        }
        public void makeAttack(Monster monster, int coef)
        {
            monster.setHealth(monster.getHealth() - (this.power + this.weapon.getDamage()) * coef + monster.getHealth() / monster.getArmor());
        }
        public void getAttack(Monster monster)
        {
            this.setHealth(this.getHealth() - monster.getDamage() + this.health / (this.shield.getProtection() + this.endurance));
        }
        public void makeCriticalAttack(Monster monster)
        {
            this.makeAttack(monster, 2);
        }
    }
}
