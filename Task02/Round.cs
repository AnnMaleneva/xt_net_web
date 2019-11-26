using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Round
    {
        private int _a; //координата центра 
        private int _b; //координата центра, пускай будут по умолчанию нулями
        private double _radius;

        public Round()
        {
            _a = A;
            _b = B;
            _radius = Radius;
        }

        public int A { get => _a; 
            set => _a = (value > 0) ? value :
                throw new ArgumentException("Invalid point"); }
        public int B { get => _b;
            set => _b = (value > 0) ? value :
                throw new ArgumentException("Invalid point"); }
        public double Radius { get => _radius; 
            set => _radius = (value >= 0) ? value :
                throw new ArgumentException("Invalid radius value. Radius value must be positive number and greater than zero."); } 
        
        internal double Сircumference { get { return 2 * Math.PI * Radius; } }
        
        internal double AreaCircle { get { return Math.PI * Radius * Radius; } }
        


    }
}
