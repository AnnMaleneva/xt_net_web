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







        }


        #region 1.1. RECTANGLE 
        public static void SquareRectangle()
        {

            int a = Convert.ToInt32(Console.ReadLine()); //здесь и далее в проекте нужно добавить try catch

            int b = Convert.ToInt32(Console.ReadLine());


            if (InputCheck(a) && InputCheck(b))
            {
                var result = a * b;
                Console.WriteLine(result);
                Console.ReadLine();
            }

        }

        public static bool InputCheck(int a)
        {
            a = (a > 0) ? a :
                throw new ArgumentException("Side length cannot be negative.");
            return true;
        }
        #endregion

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

        #region 1.3. ANOTHER TRIANGLE    

        public static void AnotherTriangle()
        {

            Console.WriteLine("Введите величену треугольника: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n * 2; i = i + 2)
            {
                for (int j = 0; j < (n * 2 - i) / 2; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        #endregion

        #region 1.4. X-MAS TREE 

        public static void XMasTree()
        {
            Console.WriteLine("Введите количество треугольников в рождественской елке :-)");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int x = 1; x <= n; x++)
            {
                for (int i = 1; i <= x * 2; i = i + 2)
                {
                    for (int j = 0; j < (n * 2 - i) / 2; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 0; k < i; k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
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

        #region 1.6. FONT ADJUSTMENT

        public static void FontAdjustment()
        {
            WritingStyle style = WritingStyle.None;

            //if (style.HasFlag(WritingStyle.Bold))
            //       Console.WriteLine("Bold");
            //if (style.HasFlag(WritingStyle.Italic))
            //       Console.WriteLine("Italic");
            //if (style.HasFlag(WritingStyle.Underline))
            //       Console.WriteLine("Underline");


            bool flag = true;

            while (flag)
            {
                Console.WriteLine("Введите стиль начетрания текста:\n 1. - bold;\n 2. - italic;\n 3. - underline.\n Выход: 4.");

                int n = Convert.ToInt32(Console.ReadLine());

                switch (n)
                {
                    case 1:
                        {
                            style = WritingStyle.Bold;

                            break;
                        }

                    case 2:
                        {
                            style = WritingStyle.Bold | WritingStyle.Italic;

                            break;
                        }

                    case 3:
                        {
                            style = WritingStyle.Bold | WritingStyle.Italic | WritingStyle.Underline;

                            break;
                        }
                    case 4:
                        {
                            flag = false;
                            break;
                        }
                    default:
                        {
                            break;
                        }

                }
                Console.WriteLine(style);
            }

            Console.ReadLine();
        }

        [Flags]
        public enum WritingStyle
        {
            None = 0,
            Bold = 1,
            Italic = 2,
            Underline = 4,
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

        #region 1.12. CHAR DOUBLER 

        public static void CharDouble() 
        {
            //работает только до пробела в строке и на английских сиволах корректнее, не знаю как исправить. может в целом моя логика не верна.

            Console.WriteLine("Введите первую строку:");
            String s1 = Console.ReadLine();

            Console.WriteLine("Введите вторую строку:");
            String s2 = Console.ReadLine();

            StringBuilder result = new StringBuilder(s1);

            char[] char2 = s2.ToCharArray();

            for (int i = 0; i < char2.Length; i++)
            {
                int indexOfChar = s1.IndexOf(char2[i]);
                result.Insert(++indexOfChar, char2[i]);

            }

            Console.WriteLine(result);

            Console.ReadLine();

        }
        #endregion


    }
}
