using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalRPG
{
    public class Staff : Weapon
    {
        public Staff()
        {
            Name = "Staff";
            BaseDamage = 1;
        }

        public override double CalculateDamage(int playerLevel)
        {
            double damage = base.CalculateDamage(playerLevel);
            // Additional calculations specific to the Staff weapon, if needed
            return damage;
        }
    }

}
