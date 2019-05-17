using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMP
{
    public class KMPSearch
    {
        public int Count = 0;

        public void SearchRun(string pat, string txt)
        {
            StringBuilder finalString = new StringBuilder(txt);

            while (true)
            {
                Console.WriteLine("Enter the element");
                string el = Console.ReadLine();
                finalString.Append(el);
                Console.WriteLine($"Final string {finalString.ToString()}");
                Search(pat, finalString.ToString());
                Console.WriteLine($"Count is {Count}");
                Count = 0;
            }
        }

        private void Search(string pat, string txt)
        {
            int M = pat.Length;
            int N = txt.Length;
            
            int[] lps = new int[M];
            int j = 0;

            computeLPSArray(pat, M, lps);

            int i = 0;
            while (i < N)
            {
                if (pat[j] == txt[i])
                {
                    j++;
                    i++;
                }
                if (j == M)
                {
                    Console.WriteLine("Found substring"
                                  + "at index " + (i - j));
                    Count++;

                    j = lps[j - 1];
                }

                else if (i < N && pat[j] != txt[i])
                {
                    if (j != 0)
                        j = lps[j - 1];
                    else
                        i = i + 1;
                }
            }
        }

        void computeLPSArray(string pat, int M, int[] lps)
        {
            int len = 0;
            int i = 1;
            lps[0] = 0; 

            while (i < M)
            {
                if (pat[i] == pat[len])
                {
                    len++;
                    lps[i] = len;
                    i++;
                }
                else
                {
                    if (len != 0)
                    {
                        len = lps[len - 1];
                    }
                    else
                    {
                        lps[i] = len;
                        i++;
                    }
                }
            }
        }
    }
}
