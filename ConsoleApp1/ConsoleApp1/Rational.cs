using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{

    class Rational : Interface
    {
        private double a;
        private double b;
        public double A
        {
            get { return a; }
            set { a = value; }
        }
        public double B
        {
            get { return b; }
            set { b = value; }
        }
        public Rational(double a, double b)
        {
            A = a;
            B = b;
        }


        public  Interface Add(Interface p)
        {
            return new Rational(this.A * p.B + this.B * p.A, this.B * p.B);
        }

        public  Interface Conj()
        {
            throw new NotImplementedException();
        }

        public  Interface Div(Interface p)
        {
            return new Rational(this.A * p.B, this.B * p.A);
        }

        public  Interface Mult(Interface p)
        {
            return new Rational(this.A * p.A, this.B * p.B);
        }

        public  Interface Sub(Interface p)
        {
            return new Rational(this.A * p.B - this.B * p.A, this.B * p.B);
        }

        public bool Equal(Interface p)
        {
            return (this.A == p.A) && (this.B == p.B);

        }
        public bool greate(Interface p)
        {
            return ((this.A / this.B) > (p.B / p.A));

        }

        public bool Less(Interface p)
        {
            return ((this.A / this.B) < (p.B / p.A));

        }


        public override string? ToString()
        {
            return (this.A / this.B).ToString();
        }

        public  bool Equ(Interface p)
        {
            throw new NotImplementedException();
        }
    }
}

    
