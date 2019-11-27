using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Triangle
    {
        private int _a;
        private int _b;
        private int _c;

        public Triangle(int _a, int _b, int _c)
        {
            A = _a;
            B = _b;
            C = _c;

        }

        public int A
        {
            get => _b;
            set => _b = (value > 0) ? value :
                throw new ArgumentException("Side length cannot be negative.");
        }

        public int B
        {
            get => _b;
            set => _b = (value > 0) ? value :
                throw new ArgumentException("Side length cannot be negative.");
        }

        public int C
        {
            get => _c;
            set => _c = (value > 0) ? value :
                throw new ArgumentException("Side length cannot be negative.");
        }


        public bool TriangleCanBe(int _a, int _b, int _c) //проверяет может ли существовать треугольник с задаными сторонами
        {
            return ((_a < (_b + _c)) && (_b < (_a + _c)) && (_c < (_a + _b)));
        }


        internal double Square(int _a, int _b, int _c)
        {
            double HalfP = (_a + _b + _c) / 2;
            
            return Math.Sqrt(HalfP * (HalfP - _a) * (HalfP - _b) * (HalfP - _c));

        }
        internal int Perimeter (int _a, int _b, int _c)
        {
            return (_a + _b + _c);
        }

 
    }
}
