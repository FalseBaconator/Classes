using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Player
    {
        public string Name;
        public int HP;
        public int Damage;
        public int XP;

        public Player(string name, int hp, int damage, int xp)
        {
            Name = name;
            HP = hp;
            Damage = damage;
            XP = xp;
        }

        public void Fight(Enemy enemy)
        {
            Console.WriteLine(Name + " fought " + enemy.Name);
            HP -= enemy.Damage;
            enemy.HP -= Damage;
            if(enemy.HP <= 0)
            {
                enemy.Die(this);
            }
        }

        public void Print()
        {
            Console.WriteLine();
            Console.WriteLine("--------------------------");
            Console.WriteLine();
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("HP: " + HP);
            Console.WriteLine("Damage: " + Damage);
            Console.WriteLine("XP: " + XP);
            Console.WriteLine();
            Console.WriteLine("--------------------------");
            Console.WriteLine();
        }

    }
}
