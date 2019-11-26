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

            
            

        }

        

        [Flags]
        public enum WritingStyle
        {
            Bold = 1,
            Italic = 2,
            Underline = 4
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

            public static bool InputCheck(int a)
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

            #region 1.7 ARRAY PROCESSING 

            public static void Array()
            {
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
                Console.WriteLine("Массив после сортировки:");
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
            //static int[] Sort(int[] arr)
            //{

            //    for (int i = 0; i < arr.Length - 1; i++)            
            //    {                                                   
            //        for (int j = 0; j < arr.Length - i - 1; j++)    
            //        {                                              
            //            if (arr[j] > arr[j + 1])
            //            {                                          
            //                int buf = arr[j];              
            //                arr[j] = arr[j + 1];  
            //                arr[j + 1] = buf; 
            //            }                                           
            //        }                                              
            //    }

            //    return arr;
            //}

            #endregion

            #region 1.8 NO POSITIVE
            public static void NoPisitive()
            {
                int[,,] array = new int[10, 10, 10];

                Random rnd = new Random();

                for (int i = 0; i < 10; i++)
                {
                    for (int z = 0; z < 10; z++)
                    {
                        for (int x = 0; x < 10; x++)
                        {
                            array[i, z, x] = rnd.Next(-50, 50);
                        }
                    }
                }

                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine();
                    for (int z = 0; z < 10; z++)
                    {
                        Console.WriteLine();
                        Console.Write("{");
                        for (int x = 0; x < 10; x++)
                        {
                            Console.Write("{0},", array[i, z, x]);

                        }
                        Console.Write("}");
                        Console.Write("\n");
                    }
                }

                for (int i = 0; i < 10; i++)
                {
                    for (int z = 0; z < 10; z++)
                    {
                        for (int x = 0; x < 10; x++)
                        {
                            if (array[i, z, x] > 0)
                                array[i, z, x] = 0;
                        }
                    }
                }

                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine();
                    for (int z = 0; z < 10; z++)
                    {
                        Console.WriteLine();
                        Console.Write("{");
                        for (int x = 0; x < 10; x++)
                        {
                            Console.Write("{0},", array[i, z, x]);

                        }
                        Console.Write("}");
                        Console.Write("\n");
                    }
                }
                Console.ReadLine();

            }

            #endregion

            #region 1.9. NON-NEGATIVE SUM 

            public static void NonNegativeSum()
            {
                int[] array = new int[50];

                Random rnd = new Random();

                for (int i = 0; i < 50; i++)
                {
                    array[i] = rnd.Next(-50, 50);
                }

                for (int i = 0; i < 50; i++)
                {
                    Console.Write("{0},", array[i]);
                }

                Console.WriteLine();

                int sum = 0;

                for (int i = 0; i < 50; i++)
                {
                    if (array[i] > 0)
                        sum += array[i];

                }

                Console.WriteLine("Сумма всех положительных чисел: {0}.", sum);
                Console.ReadLine();
            }

            #endregion

            #region 1.10. 2D ARRAY 

            public static void TwoDimensionalArray()
            {
                int[,] array = new int[3, 10];

                Random rnd = new Random();

                for (int z = 0; z < 3; z++)
                {
                    for (int x = 0; x < 10; x++)
                    {
                        array[z, x] = rnd.Next(0, 50);
                    }
                }

                for (int z = 0; z < 3; z++)
                {
                    Console.WriteLine();
                    for (int x = 0; x < 10; x++)
                    {
                        Console.Write("{0},", array[z, x]);

                    }
                }
                Console.WriteLine();
                int sum = 0;
                for (int z = 0; z < 3; z++)
                {
                    for (int x = 0; x < 10; x++)
                    {
                        if ((z + x) % 2 == 0)
                            sum += array[z, x];
                    }
                }

                Console.WriteLine("Сумма элементов на четных позициях: {0}.", sum);
                Console.ReadLine();

            }
            #endregion

            #region 1.11. AVERAGE STRING LENGTH 

            public static void AverageStringLength()
            {
                string text = "Написать программу, которая определяет среднюю длину слова во введённой текстовой строке";

                string[] words = text.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

                int totalWords = words.Length;
                Console.WriteLine("Всего слов: {0}.", totalWords);

                int r = 0;

                for (int i = 0; i < words.Length; i++)
                {
                    r += words[i].Length;

                }
                Console.WriteLine("Сумма всех букв в словах: {0}.", r);

                int result = r / totalWords;

                Console.WriteLine("Средняя длинна слов в исходной строке: {0}.", result);

                //foreach (string s in words)
                //{
                //    Console.WriteLine(s);
                //    Console.WriteLine(s.Length);

                //}


                Console.ReadLine();
            }

            #endregion

        
    }
}
