using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class BasePerson
    {
        protected string name;
        protected int health;
        protected int healthMax;
        protected int energy;
        protected int level;
        public BasePerson(string name, int level)
        {
            this.name = name;
            this.level = level;
        }

        public BasePerson()
        {
        }

        public void printInfo() 
        { 
            Console.WriteLine($"Ім'я персонажа: {this.name}\nЗдоров'я персонажа: {this.name}\nЕнергія персонажа: {this.name}\nРівень персонажа: {this.level}"); 
        }
        public int getLevel() => this.level;
        public int getHealth() => this.health;
        public void setHealth(int health) => this.health = health;
        public int getEnergy() => this.energy;
        public void setEnergy(int energy) => this.energy = energy;
    }
}
