using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalRPG
{
    public class Sword : Weapon
    {
        public Sword()
        {
            Name = "Sword";
            BaseDamage = 3;
        }

        public override double CalculateDamage(int playerLevel)
        {
            double damage = base.CalculateDamage(playerLevel);
            // Additional calculations specific to the Sword weapon, if needed
            return damage;
        }
    }


}
