using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task04
{
    class Sorting
    {
        public event Action OnStopSort = delegate { };

        public void SortInAdditionalThread(int[] array, Func<int, int, bool> funcAction)
        {
            new Thread(() => { SortArray(array, funcAction); });
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
                throw new ArgumentException("Function argument cannot be null or empty.");

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
