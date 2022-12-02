using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inhertance
{//overloading method
    public class Add
    {
        public int Cal(int a, int b)
        {
            return a + b;
        }
        public int Cal(int a, int b, int c)
        {
            return a + b + c;
        }
        public double Cal(double a, int b)
        {
            return a + b;
        }
        public double Cal(float a, double b)
        {
            return a + b;
        }
    }
}
