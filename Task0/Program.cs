using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task0
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a positive number.");
            int N = Convert.ToInt32(Console.ReadLine());
            ResultString(N);
            Console.WriteLine("Result: " + ResultString(N));
            Console.ReadLine();

            Console.WriteLine("Enter a number to check if it is a prime number or not.");
            int num = Convert.ToInt32(Console.ReadLine());
            bool result = PrimeNumber(num);
            Console.WriteLine("Is this a prime number? " + result);
            Console.ReadKey();

            Console.WriteLine("Enter the size of the square (odd number).");
            int stars = Convert.ToInt32(Console.ReadLine());
            StarsSquare(stars);

            Console.WriteLine("Enter the number of subarrays");
            int [][] a = CreateJaggedArray();
            Console.WriteLine("Jagged array before sorting.");
            ShowArray(a);
            ArraySort(a);
            Console.WriteLine("Jagged array after sorting.");
            ShowArray(a);
                                   
        }

        #region 0.1. SEQUENCE 
        public static string ResultString(int N)

        {
            int[] Array = new int[N];

            for (int x = 0; x < N; x++)
            {
                Array[x] = x + 1;
            }

            StringBuilder sb = new StringBuilder(Array.Length);
            foreach (int ch in Array)
            {
                sb.Append(ch);
            }

            string finalString = sb.ToString();
            finalString = String.Join<char>(",", finalString);

            return finalString;
        }

        #endregion

        #region 0.2. SIMPLE 
        public static bool PrimeNumber(int num)
        {
            if (num < 2)
                return false;

            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }

            }
            return true;
        }

        #endregion

        #region 0.3. SQUARE 
        public static void StarsSquare(int stars)
        {
            int n = stars / 2;

            for (int i = 0; i < stars; i++)
            {

                for (int j = 0; j <= stars - 1; j++)
                {
                    if (j == n && i == n)
                        Console.Write(" ");
                    else
                        Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        #endregion

        #region 0.4. ARRAY (TASK 0.5) 
        public static int [][] CreateJaggedArray()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter subarrays sizes.");

            int[][] jagged = new int[n][];

            for (int x = 0; x < n; x++)
            {
                int m = Convert.ToInt32(Console.ReadLine());
                jagged[x] = new int[m];
            }    
            
            Random rnd = new Random();

            for (int a = 0; a < jagged.Length; a++)
            {
                for (int y = 0; y < jagged[a].Length; y++)
                {
                    jagged[a][y] = rnd.Next(0, 100);
                }
            }
            return jagged;            
        }

        public static void ShowArray(int [][] array)
        {
            for (int i = 0; i < array.Length; ++i)
            {
                Console.Write("{");
                for (int j = 0; j < array[i].Length; ++j)
                {
                    Console.Write("{0},", array[i][j]);
                }
                Console.Write("}");
                Console.Write("\n");
            }
            Console.ReadKey();
        }


        public static void ArraySort(int[][] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
               Array.Sort(array[i]);
            }
              
        }
        #endregion



    }
}
