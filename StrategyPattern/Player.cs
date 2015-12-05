using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Player
    {
        // access the IWeapon Interface
        private IWeapon weapon;
        // create a setter for the interface
        public IWeapon SetWeapon
        {
            set
            {
                this.weapon = value;
            }
        }


        // create a constructor
        public Player()
        {
        }
        public void Attack()
        {
            weapon.Use();
        }

    }
}
