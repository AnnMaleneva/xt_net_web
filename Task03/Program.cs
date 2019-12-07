using System;
using System.Collections.Generic;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lost lost = new Lost();
            //lost.Method();

            DynamicArray<int> ar = new DynamicArray<int>(2);
            ar.Add(0);
            ar.Add(2);

            foreach (var item in ar)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
