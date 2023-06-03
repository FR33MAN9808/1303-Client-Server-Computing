using System;
using System.Collections.Generic;
using System.Text;

namespace ClntSrvrWk1.Lessons.Week4.ObjectType
{
    public class Car
    {
        private Color color;

        public Car(Color color) 
        {
            this.color = color;
        }

        public Color GetColor()
        {
            return this.color;
        }
    }
}
