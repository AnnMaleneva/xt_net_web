using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    abstract class Figures
    {
        protected int baseX;
        protected int baseY;


        public abstract int X { get; }
        public abstract int Y { get; }

        //abstract public Figures CreateFigure();

        abstract public void ShowFigure();
   
    }

    class Line : Figures
    {
        private int _secondX, _secondY;

        public Line(int baseX, int baseY, int SecondX, int SecondY) : base()
        {
            _secondX = SecondX;
            _secondY = SecondY;

        }

        public int SecondX
        {
            get => _secondX;
            set => _secondX = (value >= 0) ? value :
                throw new ArgumentException("Invalid point");
        }

        public int SecondY
        {
            get => _secondY;
            set => _secondY = (value >= 0) ? value :
                throw new ArgumentException("Invalid point");
        }

        public double LineLength()
        {
            return Math.Abs(Math.Sqrt(Math.Pow((SecondX - baseX), 2) + Math.Pow((SecondY - baseY), 2)));
        }

        public override int X => throw new NullReferenceException();

        public override int Y => throw new NullReferenceException();

        //public override Figures CreateFigure()
        //{
        //    return new Line(5, 6);
        //}

        public override void ShowFigure()
        {

            Console.WriteLine("Line: {0}, {1}, {2}, {3}, {4}.", baseX, baseY, SecondX, SecondY, LineLength());
        }
    }

    //class Rectangle : Figures
    //{
    //    public override int X => throw new NullReferenceException(); //коориднаты пересечения диагоналей

    //    public override int Y => throw new NullReferenceException();

    //    private int _sideA;
    //    private int _sideB;

    //    public Rectangle()
    //    {
    //        A = _sideA;
    //        B = _sideB;
    //    }

    //    public int A
    //    {
    //        get => _sideA;
    //        set => _sideA = (value > 0) ? value :
    //            throw new ArgumentException("Side length cannot be negative.");
    //    }

    //    public int B
    //    {
    //        get => _sideB;
    //        set => _sideB = (value > 0) ? value :
    //            throw new ArgumentException("Side length cannot be negative.");
    //    }

    //    public override Figures CreateFigure()
    //    {
    //        return new Rectangle();
    //    }

    //    public override void ShowFigure()
    //    {
    //        Console.WriteLine("Rectangle");
    //    }

    //    public double RectangleArea => A * B;

    //    public double RectanglePerimeter => A + B;

    //}

    //class Circle : Figures
    //{
    //    public override int X => throw new NotImplementedException();

    //    public override int Y => throw new NotImplementedException();

    //    public override Figures CreateFigure()
    //    {
    //        return new Circle();
    //    }

    //    public override void ShowFigure()
    //    {
    //        Console.WriteLine("Circle");
    //    }

    //    protected double _radius;

    //    protected virtual double Radius2
    //    {
    //        get => _radius;
    //        set => _radius = (value >= 0) ? value :
    //            throw new ArgumentException("Invalid radius value. Radius value must be positive number and greater than zero.");
    //    }

    //    protected virtual double Сircumference2 { get { return 2 * Math.PI * Radius2; } }
    //}

    //class Round2 : Circle
    //{
    //    public override int X => throw new NotImplementedException();

    //    public override int Y => throw new NotImplementedException();

    //    public override Figures CreateFigure()
    //    {
    //        return new Circle();
    //    }

    //    public override void ShowFigure()
    //    {
    //        Console.WriteLine("Circle");
    //    }
    //    protected override double Radius2
    //    {
    //        get => _radius;
    //        set => _radius = (value >= 0) ? value :
    //            throw new ArgumentException("Invalid radius value. Radius value must be positive number and greater than zero.");
    //    }

    //    protected override double Сircumference2 { get { return 2 * Math.PI * Radius2; } }

    //    protected virtual double Area2 { get { return Math.PI * Radius2 * Radius2; } }


    //}

    //class Ring2 : Round2
    //{
    //    public override int X => throw new NotImplementedException();

    //    public override int Y => throw new NotImplementedException();

    //    public override Figures CreateFigure()
    //    {
    //        return new Ring2();
    //    }

    //    public override void ShowFigure()
    //    {
    //        Console.WriteLine("Ring2");
    //    }
    //    protected override double Radius2
    //    {
    //        get => _radius;
    //        set => _radius = (value >= 0) ? value :
    //            throw new ArgumentException("Invalid radius value. Radius value must be positive number and greater than zero.");
    //    }
        
    //    private double _outerRadius; //внешний радиус, внутрений радиус тот же что у круга, для этого примера
    //    private double _ringArea;  //площадь кольца
    //    private int _outerСircumference; //длина внешней окружности
    //    private int _totalLength; //суммарная длина обеих окружностей

    //    public double OuterRadius
    //    {
    //        get => _outerRadius;
    //        set => _outerRadius = (value >= 0) ? value :
    //            throw new ArgumentException("Invalid radius value. Radius value must be positive number and greater than zero.");
    //    }

    //    public double RingArea()
    //    {

    //        double ringarea = Math.PI * OuterRadius * OuterRadius;
    //        double result = ringarea - Area2;
    //        return result;
    //    }

    //    public double OuterСircumference { get { return 2 * Math.PI * OuterRadius; } }

    //    public double TotalLength()
    //    {
    //        return OuterСircumference + Сircumference2; 
    //    }
    //}

}
