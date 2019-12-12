using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    public class WordFrequency
    {
        public void FindWords()
        {
            string str = "New english text or nor text";

            List<string> words = new List<string>(str.ToLower().Split(new char[] { ' ', ',', '.', '\n' }));

            for (int i = 0; i < words.Count; i++)
            {
                int count = 0;

                for (int j = 0; j < words.Count; j++)
                {
                    if (words[i] == words[j])
                        count++;

                }
                Console.WriteLine("Word {0} is found {1} time.", words[i], count);

            }
            Console.ReadKey();
        }
    }
}
