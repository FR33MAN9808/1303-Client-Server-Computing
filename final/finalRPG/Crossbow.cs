using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalRPG
{
    public class Crossbow : Weapon
    {
        public Crossbow()
        {
            Name = "Crossbow";
            BaseDamage = 2.5;
        }

        // Crossbow does not have any special calculations, so the base CalculateDamage method is sufficient
    }

}
