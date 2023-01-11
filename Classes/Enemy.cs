using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Enemy
    {
        public string Name;
        public int HP;
        public int Damage;
        public int XP;

        public Enemy(string name, int hp, int damage, int xp)
        {
            Name = name;
            HP = hp;
            Damage = damage;
            XP = xp;
        }

        public void Die(Player player)
        {
            player.XP += XP;
            Console.WriteLine(Name + " has Died!");
            Console.WriteLine(player.Name + " has gained " + XP + " experience points");
        }
    }
}
