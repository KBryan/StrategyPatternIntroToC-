using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Gun : IWeapon
    {
        // public constructor
        public Gun()
        {
        }
        public void Use()
        {
            Console.WriteLine("Using a gun");
        }
    }
}
