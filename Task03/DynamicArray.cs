using System;
using System.Collections;
using System.Collections.Generic;


namespace Task03
{
    class DynamicArray<T> : IEnumerable<T>, IEnumerator<T>
    {
        public T[] array;
        public int index;
        public int count = 0; //стоит переименовать count в position, но пока что так, иначе запутаюсь
        public int Index { get => index; set => index = (value < 0) ? value : throw new ArgumentException("Invalid point"); }
        public int Length { get; set; } 

        public int Capacity { get { return array.Length; } } 

        Array
        public DynamicArray()
        {
            this.array = new T[8];

        }

        public DynamicArray(int size)
        {
            Length = size;
            this.array = new T[size];
        }

        public DynamicArray(IEnumerable<T> myCollection)
        {
            int sizeOfmyCollection = 0;
            foreach (var item in myCollection)
            {
                sizeOfmyCollection++;
            }
            array = new T[sizeOfmyCollection];
            int i = 0;
            foreach (var item in myCollection)
            {
                array[i] = item;
                i++;
            }

        }

        public T this[int index]
        {
            set
            {
                if (Length >= index)
                    array[index] = value;
            }
            get
            {
                if (Length >= index)
                    return array[index];
                else
                    throw new ArgumentOutOfRangeException();
            }
        }

        public T[] ChangeCapacity(int newCapacity)
        {
            int newLength = array.Length + newCapacity;
            T[] newArray = new T[newLength];
            for (int i = 0; i < newLength; i++)
            {
                newArray[i] = array[i];
            }
            return newArray;
        }

        public void Add(T item)
        {
            array[count] = item;
            count++;
            if (Length < count)
                ChangeCapacity(Length * 2);

        }

        public void AddRange(IEnumerable<T> myCollection)
        {
            int sizeOfmyCollection = 0;
            foreach (var item in myCollection)
            {
                sizeOfmyCollection++;
            }
            ChangeCapacity(Length + sizeOfmyCollection);
            foreach (var item in myCollection)
            {
                array[count] = item;
                count++;
            }

        }
        
        public bool Remove(T item) //не проверяла изменится ли емкость массива сама
        {
            int indexToRemove = -1;
            for (int i = 0; i < Length; i++)
            {
                if (array[i].Equals(item))
                    indexToRemove = i;
            }
            if (indexToRemove == -1) //если значение индекса не изменилось, значит такого элемента нет в коллекции
                return false;
            array[indexToRemove] = default;
            return true;
        } 

        public IEnumerator GetEnumerator()
        {
            return array.GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return ((IEnumerable<T>)array).GetEnumerator();
        }


        public T Current 
        {
            get
            {
                if (count == -1 || count >= array.Length)
                    throw new InvalidOperationException();
                return array[count];
            }
        }

        object IEnumerator.Current => throw new NotImplementedException();

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            if (count != Length)
                count++;
            else
                throw new ArgumentException("Достигнут конец коллекции.");
            return true;

        }

        public void Reset()
        {
            count = -1;
        }

        public bool Insert(T item, int positionIndex)
        {
            T temp = default; //буферная переменная
            if (positionIndex < 0 | positionIndex > Length)
                throw new ArgumentOutOfRangeException();
            else
            {
                ChangeCapacity(1);
                array[positionIndex] = temp;
                temp = array[positionIndex + 1]; //тут нужно чтоб все элементы сдвинулись право

                for (int i = Length; i > positionIndex; i--) //TODO: проверить работает ли
                {
                    array[i] = array[i - 1];
                }
                array[positionIndex] = item;
                return true;
            }
        }

    }
}
