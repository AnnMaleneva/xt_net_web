using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string to search for a date.(format dd-mm-yyyy)");
            string strDate = Console.ReadLine();
            RegexForSearch regexForSearch = new RegexForSearch();
            regexForSearch.DataSearch(strDate);
            Console.ReadKey();

            string str = "<b>Это</b> текст <i>с</i> <font color=\"red\">HTML</font> кодами";
            Console.WriteLine(RegexForSearch.HTMLReplace(str));


        }
    }
}
