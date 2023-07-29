using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalRPG
{
    public class Arrow : Weapon
    {
        public Arrow()
        {
            Name = "Arrow";
            BaseDamage = 2;
        }

        // Arrow does not have any special calculations, so the base CalculateDamage method is sufficient
    }

}
