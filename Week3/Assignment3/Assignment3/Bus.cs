using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Bus:Car
    {
        public Bus(string brand, int maxSpeed) : base(brand, maxSpeed)
        {
            this.brand = brand;
            this.maxSpeed = maxSpeed;
        }
    }
}
