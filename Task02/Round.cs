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

        //public int A { get; set; }     
        //public int B { get; set; }
        public double Radius 
        {
            get 
            {
                return _radius;
            }
            set 
            {
                if (value <= 0)
                    throw new ArgumentException("Invalid radius value. Radius value must be positive number and greater than zero.");
                _radius = value;
            } 
        }

        internal double Сircumference { get { return 2 * Math.PI * Radius; } }
        

        internal double AreaCircle { get { return Math.PI * Radius * Radius; } }
        


    }
}
