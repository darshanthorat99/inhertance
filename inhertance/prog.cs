using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inhertance
{
  abstract  public class Shape
    {
        public abstract void CalculateArea();
    }
    public class Circle: Shape
    {
        public int r;
        public double result;
        public Circle(int r)
        {
            this.r = r;
        }
        public override void CalculateArea()
        {
            result = (double)r * r * 3.14;
        }
        public override string ToString()
        {
            return $"the area od circle is{result}";
        }

        public class Rectangal : Shape
        {
            public double l;
            public double b;
            public double result;
            public Rectangal(double l, double b)
            {
                this.l = l;
                this.b = b;
            }
            public override void CalculateArea()
            {
                result = l * b;
            }
            public override string ToString()
            {
                return$"the area of rectangale {result}";   
            }
        }

    }
}
