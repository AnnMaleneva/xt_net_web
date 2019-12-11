using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class Lost
    {
        public void Method()
        {
            int n = 6; //вынести из метода, добавить проверку
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = i + 1;
            }

            List<int> numbers = new List<int>();

            numbers.AddRange(array);

            int indexToRemove = 0; //переименовать
            int indexShift = 1;
            
            int numOfPeopleLeft = n;

            while (true)
            {
                indexToRemove = (indexToRemove + indexShift) % numOfPeopleLeft--;
                numbers.RemoveAt(indexToRemove);
                Console.WriteLine("---------");
                foreach (var item in numbers)
                {
                    Console.WriteLine(item);
                }

                if (numOfPeopleLeft == 1)
                    break;
            }
            Console.ReadLine();
        }
    }
}
