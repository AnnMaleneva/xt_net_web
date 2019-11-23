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
            //SquareRectangle();

            int[] array = new int[50];
            Random rnd = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(0, 1000);
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            //Console.ReadLine();

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int buf = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = buf;
                    }
                }
            }

            //Sort(array);
            Console.WriteLine("Массив после сортировки:" );
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            int a = array[0];
            int b = array[49];


            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.ReadLine();
        }

            static int[] Sort(int[] arr)
            {
                
                for (int i = 0; i < arr.Length - 1; i++)            
                {                                                   
                    for (int j = 0; j < arr.Length - i - 1; j++)    
                    {                                              
                        if (arr[j] > arr[j + 1])
                        {                                          
                            int buf = arr[j];              
                            arr[j] = arr[j + 1];  
                            arr[j + 1] = buf; 
                        }                                           
                    }                                              
                }

                return arr;
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
        } //плохой код, работает, но не корректно, позже вернусь для изменения

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
        }  //плохой код, работает, но не корректно, позже вернусь для изменения

        #region 1.2. TRIANGLE 

        public static void Triangle()
        {
            Console.WriteLine("Enter the size of the right-angled triangle.");

            int n = Convert.ToInt32(Console.ReadLine());

            for (string number = ""; number.Length < n; number += "*")
                Console.WriteLine(number);
            Console.ReadLine();

        }

        #endregion

        #region 1.3. ANOTHER TRIANGLE        //не работает, доделать 

        public static void AnotherTriangle()
        {

            Console.WriteLine("Введите величену треугольника: ");
            int v = Convert.ToInt32(Console.ReadLine());
            string[] a = new string[v];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = "*";
                Console.WriteLine();
                for (int j = a.Length, k = 0; j > 0 && k < a.Length; k++, j++)
                {
                    if (i > k || i > j)
                    {
                        Console.Write(a[i]);
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }
            }
            Console.ReadLine();
        }

        #endregion    


        #region 1.5. SUM OF NUMBERS

        public static void SumOfNumbers()
        {
            int a = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    a += i;
                }
            }
            Console.WriteLine(a);
            Console.ReadKey();

        }

        #endregion




    }
}
