using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Round
    {
        private int _a; 
        private int _b; 
        private double _radius;

        public Round(int _a, int _b, double _radius)
        {
            A = _a;
            B = _b;
            Radius = _radius;
   
        }

        public int A { get => _a; 
            set => _a = (value >= 0) ? value :
                throw new ArgumentException("Invalid point"); }
        public int B { get => _b;
            set => _b = (value >= 0) ? value :
                throw new ArgumentException("Invalid point"); }
        public double Radius { get => _radius; 
            set => _radius = (value >= 0) ? value :
                throw new ArgumentException("Invalid radius value. Radius value must be positive number and greater than zero."); } 
        
        internal double Сircumference { get { return 2 * Math.PI * Radius; } } //здесь сделала расчеты через вычисляемые свойства, в следующем задании через методы
        
        internal double AreaCircle { get { return Math.PI * Radius * Radius; } }
        


    }
}
