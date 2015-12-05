using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IWeapon weapon = null;
            Player player = new Player();
            // game loop
            while (true)
            {
                Console.WriteLine("Choose a weapon 1 = Gun, 2 = Sword");
                String input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        weapon = new Gun();
                        break;
                    case "2":
                        weapon = new Sword();
                        break;
                }
                player.SetWeapon = weapon;
                player.Attack();
            }
        }
    }
}
