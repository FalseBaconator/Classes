using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {

        static Player player = new Player("Buddy", 10, 2, 0);
        static Enemy slime = new Enemy("Slime", 5, 1, 5);

        static void Main(string[] args)
        {
            player.Print();
            player.Fight(slime);
            player.Print();
            player.Fight(slime);
            player.Print();
            player.Fight(slime);
            player.Print();

            Console.ReadKey(true);
        }
    }
}
