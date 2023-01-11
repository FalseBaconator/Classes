using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {

        static Player player = new Player("Test", 10, 2, 0);
        static Enemy slime = new Enemy("Slime", 5, 1, 5);

        static void Main(string[] args)
        {
            Console.Write("What's your name? ");
            player.Name = Console.ReadLine();
            player.Print();
            player.Fight(slime);
            player.Print();
            player.Fight(slime);
            player.Print();
            player.Fight(slime);
            player.Print();

            Console.WriteLine("Press any key to close");
            Console.ReadKey(true);
        }
    }
}
