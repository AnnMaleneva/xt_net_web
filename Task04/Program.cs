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
            //Thread thread = new Thread(() => { objectForSorting.SortArray(array, deleg); });
            objectForSorting.SortInAdditionalThread(array, deleg);
            //thread.Start();

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

}

