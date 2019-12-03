using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Ring : Round
    {
        private double _outerRadius; //внешний радиус, внутрений радиус тот же что у круга, для этого примера
        private double _ringArea;  //площадь кольца
        private int _outerСircumference; //длина внешней окружности
        private int _totalLength; //суммарная длина обеих окружностей

        public double OuterRadius
        {
            get => _outerRadius;
            set => _outerRadius = (value >= 0) ? value :
                throw new ArgumentException("Invalid radius value. Radius value must be positive number and greater than zero.");
        }

        public Ring(int _a, int _b, double _radius, double _outerRadius) : base(_a, _b, _radius)
        {
            OuterRadius = _outerRadius;

        }

        public double RingArea()
        {

            double ringarea = Math.PI * OuterRadius * OuterRadius;
            double result = ringarea - AreaCircle; //тут хочу чтобы в эти вычисления включались результаты вычислений из базаового класса
            return result; 
        }

        public double OuterСircumference { get { return 2 * Math.PI * OuterRadius; } } 

        public double TotalLength { get { return OuterСircumference + Сircumference; } }
        

    }
}
