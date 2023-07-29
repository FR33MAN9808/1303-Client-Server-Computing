using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalRPG
{
    public class Dagger : Weapon
    {
        public Dagger()
        {
            Name = "Dagger";
            BaseDamage = 2;
        }

        public override double CalculateDamage(int playerLevel)
        {
            double damage = base.CalculateDamage(playerLevel);
            // Additional calculations specific to the Dagger weapon, if needed
            return damage;
        }
    }

}
