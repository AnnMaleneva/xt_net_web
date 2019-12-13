using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, bool> deleg = delegate (int a, int b) { return a > b; };

            Sorting objectForSorting = new Sorting();

            int[] array = new int[] { 6, 7, 2, 1, 3, 4, 5, 9, 8 };
            objectForSorting.OnStopSort += ObjectForSorting_OnStopSort;


            objectForSorting.SortArray(array, deleg);
            Thread thread = new Thread(() => { objectForSorting.SortArray(array, deleg); });
            thread.Start();
         
            objectForSorting.OnStopSort -= ObjectForSorting_OnStopSort;     


            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            string[] arrayString = new string[] { "каждый", "охотник", "желает", "знать", "где", "сидит", "фазан" };

            objectForSorting.SortString(arrayString, deleg);

            Console.WriteLine("Режим магистра Йоды - ON");
            foreach (var item in arrayString)
            {
                Console.WriteLine(item);
            }


            Console.ReadLine();

        }

        private static void ObjectForSorting_OnStopSort()
        {
            Console.WriteLine("Sort is finish."); ;
        }
    }
    class Sorting
    {

        public event Action OnStopSort = delegate { };

        public void SortInAdditionalThread(int[] array, Func<int, int, bool> funcAction)
        {
            new Thread(() =>
            {
                SortArray(array, funcAction);
                //OnStopSort?.Invoke();
            }).Start();
        }

        public void SortArray(int[] array, Func<int, int, bool> funcAction)
        {
            OnStopSort?.Invoke();
            if (funcAction == null)
                throw new ArgumentException("funcAction", "Function argument cannot be null or empty.");

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

        public void SortString(string[] array, Func<int, int, bool> funcString)
        {
            
            if (funcString == null)
                throw new ArgumentException("funcAction", "Function argument cannot be null or empty.");

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
                            array[j + 1] = temp;

                            //IEnumerable<string> query = from word in array
                            //                            orderby word.Length
                            //                            select word;
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
