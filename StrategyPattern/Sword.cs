using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Sword : IWeapon
    {
        public Sword()
        {

        }
        public void Use()
        {
            Console.WriteLine("Using a Sword");
        }
    }
}
