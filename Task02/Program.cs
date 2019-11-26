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
            Round round = new Round();

            round.A = -4;
            Console.WriteLine(round.A); //excepsion
            
            round.Radius = 6;

            var cir = round.Сircumference;
            var area = round.AreaCircle;

            Console.WriteLine("Длина описаной окружности: {0}", cir);
            Console.WriteLine("Площадь круга: {0}.", area);
            Console.ReadKey();
            
        }
    }
}
