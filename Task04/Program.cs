using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, bool> deleg = delegate (int a, int b) { return a > b; };

            int[] array = new int[] { 6, 7, 2, 1, 3, 4, 5, 9, 8 };

            SortArray(array, deleg);
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            string[] arrayString = new string[] { "каждый", "охотник", "желает", "знать", "где", "сидит", "фазан" };
            SortString(arrayString, deleg);
            Console.WriteLine("Режим магистра Йоды - ON");
            foreach (var item in arrayString)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

        }

        static void SortArray(int[] array, Func<int, int, bool> funcAction)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (funcAction(array[j], array[j + 1]))
                    {
                        Swap(array, j, j + 1);
                    }
                }
            }

        }

        static void SortString(string[] array, Func<int, int, bool> funcString)
        {


            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {


                    if (funcString(array[j].Length, array[j + 1].Length))
                    {

                        if (array[j].Length != array[j + 1].Length)
                        {
                            string temp = array[j];
                            array[j] = array[j + 1];
                            array[j+1] = temp;

                            IEnumerable<string> query = from word in array
                                                        orderby word.Length
                                                        select word;
                        }


                    }
                }
            }
        }

        static void Swap(int[] array, int left, int right)
        {
            if (left != right)
            {
                int temp = array[left];
                array[left] = array[right];
                array[right] = temp;
            }
        }
    }
}
