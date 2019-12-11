using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    public class WordFrequency
    {
        public static void MyClass()
        {
            Dictionary<int, string> MyDictionary = new Dictionary<int, string>();

            string newStr = "new english text";

            List<string> words = new List<string>(newStr.ToLower().Split(new char[] { ' ', ',', '.', '\n' }));

            foreach (var item in words)
            {
                MyDictionary.Add(1, item);
            }
        }
    }
}
