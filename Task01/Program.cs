using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            SquareRectangle();
        }

        public static void SquareRectangle()
        {
            var A = Console.ReadLine();
            int a = 0;
            if (Int32.TryParse(A, out a))
            {
                Console.WriteLine("Good");
            }
            else
            {
                Console.WriteLine("Incorrect");
            }
            var B = Console.ReadLine();
            int b = 0;
            if (Int32.TryParse(B, out b))
            {
                Console.WriteLine("Good");
            }
            else
            {
                Console.WriteLine("Incorrect");
            }

            //InputCheck(a);
            //InputCheck(b);
            if (InputCheck(a) && InputCheck(b))
            {
                var result = a * b;
                Console.WriteLine(result);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Noup");
                Console.ReadLine();
            }
        }

        public static bool InputCheck (int a)
        {
            //a = Convert.ToInt32(Console.ReadLine());
            //try
            //{
            //    a = Convert.ToInt32(Console.ReadLine());
            //}
            //catch
            //{
            //    Console.WriteLine("Exeption");
            //    return false;
            //}

            if (a == 0)
            {
                Console.WriteLine("Incorrect");
                return false;
            }

            else if (a < 0)
            {
                Console.WriteLine("Incorrect");
                return false;
            }

            else
            {
                return true;
            }
        }



    }
}
