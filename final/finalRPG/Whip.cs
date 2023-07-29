using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalRPG
{
    public class Whip : Weapon
    {
        public Whip()
        {
            Name = "Whip";
            BaseDamage = 1.5;
        }

        // Whip does not have any special calculations, so the base CalculateDamage method is sufficient
    }

}
