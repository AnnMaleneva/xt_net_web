using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class MyString //компилятор просит переопределить Equals() и GetHashCode(), это обязательно? ведь в моей логике они не нужны
    {
        private char[] str;

        public MyString(char[] str)
        {
            this.str = str;
        }

        public static bool operator ==(MyString str1, MyString str2)
        {
            return Enumerable.SequenceEqual(str1.str, str2.str);
        }
        public static bool operator !=(MyString str1, MyString str2)
        {
            return !Enumerable.SequenceEqual(str1.str, str2.str);
        }

        public static MyString operator +(MyString str1, MyString str2)
        {
            return new MyString(str1.str.Concat(str2.str).ToArray());
        }
        
        public int FindSimbol(char c)
        {
            return Array.IndexOf(str, c);
        }


        public static explicit operator MyString(char[] array)
        {
            return new MyString(array);
        }

        public override string ToString()
        {
            return new string(str);
        }


    }
}
