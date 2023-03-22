using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Engine
    {
        private Player player = new Player();
        public Engine()
        {
            this.player = this.createPlayer();
        }
        public Monster monsterGenerator()
        {
            string[] monsterName = { "Rebisa", "Gendrostra", "Orol", "Kusugyurolk", "Brachyrben", "Gilkuman", "Flame", "Yian Kun", "White Behezan", "Basana" };
            Random random = new Random();
            return new Monster(monsterName[random.Next(monsterName.Length)], player.getLevel() + random.Next(2));
        }
        public Player createPlayer()
        {
            char key;
            do
            {
                Console.Write("Доступні гравці!\n1. Варвар\n2. Танк\n3. Розбійник\nОберіть персонажа: ");
                key = Console.ReadKey().KeyChar;
            } while (key != '1' || key != '2' || key != '3');
            Console.Write("Введіть ім'я персонажа: ");
            string name = Console.ReadLine();
            if (key == '1')
            {
                return new Barbarian(name);
            }
            else if (key == '2')
            {
                return new Tank(name);
            }
            else
            {
                return new Robber(name);
            }
        }
        public Weapon generateWeapon()
        {
            string[] weaponNames = { "Пістолет", "Кинжал", "Граната", "Лук", "Меч", "Автомат", "Бита" };
            Random random = new Random();

            return new Weapon(weaponNames[random.Next(weaponNames.Length)], random.Next(3, 21));
        }
        public Shield generateShield()
        {
            string[] shieldNames = { "Бронежилет", "Плита з металів", "Куленепробивне скло", "Активна броня", "Космічна броня", "Кабельна броня", "Комбінована броня" };
            Random random = new Random();

            return new Shield(shieldNames[random.Next(shieldNames.Length)], random.Next(3, 21));
        }
    }
}
