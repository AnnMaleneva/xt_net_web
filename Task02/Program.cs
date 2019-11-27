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
            Round round = new Round(0, 0, 6);
            
            var cir = round.Сircumference;
            var area = round.AreaCircle;

            Console.WriteLine("Длина описаной окружности: {0}", cir);
            Console.WriteLine("Площадь круга: {0}.", area);
            Console.ReadKey();



            Triangle triangle = new Triangle(5, 6, 7);


            if (triangle.TriangleCanBe(triangle.A, triangle.B, triangle.C))
            {

                var S = triangle.Square(triangle.A, triangle.B, triangle.C);
                var P = triangle.Perimeter(triangle.A, triangle.B, triangle.C);
                Console.WriteLine("Площадь треугольника: {0}.", S);
                Console.WriteLine("Периметр треугольника: {0}", P);
                Console.ReadKey();
            }
            else
                Console.WriteLine("Такой треугольник невозможен.");

            Console.ReadKey();



            User user = new User("Иван","Иванов","Иванович", new DateTime (1992, 02, 04));

            Console.WriteLine("Имя пользователя: {0}." + "\n" + "Фамилия пользователя: {1}." + "\n" + 
                "Отчество пользователя: {2}." + "\n" + "Дата рождения пользователя: {3}." + "\n" + 
                "Возраст пользователя: {4}", user.UserName, user.UserSurname, user.UserPatronymic, user.UserBirthday, user.UserAge);

            Console.ReadLine();


        }
    }
}
