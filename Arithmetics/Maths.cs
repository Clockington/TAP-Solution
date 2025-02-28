using System.Runtime.CompilerServices;

namespace Arithmetics
{
    public class Maths
    {
        public double a, b, r;

        public Maths(double a, double b, double r)
        {
            this.a = a;
            this.b = b;
            this.r = r;
        }

        public double Add() { return r = a + b; }
        public double Sub() { return r = a - b; }
        public double Mul() { return r = a * b; }
        public double Div() { return r = a / b; }
        public double Pow()
        {
            r = 1;
            for (int i = 0; i < b; i++)
                r *= a;
            return r;
        }
        public double LogN() { return r = System.Math.Log(a, b); }
    }
}
