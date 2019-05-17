using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMP
{
    class Program
    {
        static void Main(string[] args)
        {
            string txt = "ABABDABACDABABCABAB";
            string pat = "ABA";
            new KMPSearch().SearchRun(pat, txt);
            Console.ReadKey();
        }
    }
}
