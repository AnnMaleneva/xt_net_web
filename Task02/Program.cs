using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            Round r = new Round();

            r.Radius = 6;

            var cir = r.Сircumference;
            var area = r.AreaCircle;

            Console.WriteLine("Длина описаной окружности: {0}", cir);
            Console.WriteLine("Площадь круга: {0}.", area);
            Console.ReadKey();
            
        }
    }
}
