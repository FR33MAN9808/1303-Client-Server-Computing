using System;
using System.Collections.Generic;
using System.Text;

namespace ClntSrvrWk1.Lessons.Week4.ObjectType
{
    public class Car
    {
        private Color color;
        private string vin;

        public Car(Color color)
        {
            this.color = color;
        }

        public Car(string vin, Color color) 
        {
            this.color = color;
            this.vin = vin;
        }

        public Color GetColor()
        {
            return this.color;
        }

        public string GetVin() 
        { 
            return this.vin;
        }
    }
}
