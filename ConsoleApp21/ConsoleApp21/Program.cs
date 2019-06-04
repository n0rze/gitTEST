using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var result = dictionary(@"C:\test.txt");

            foreach (var key in result.Values)
            {
                Console.WriteLine(key);
            }
        }


        public static Dictionary<string, int> dictionary(string path)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            string filename = path;
            string text = File.ReadAllText(filename, Encoding.Default);
            string[] words = Regex.Split(text, @"(\a\r)?\s+|\W+|\d+");

            List<char> check;

            foreach (string word in words)
            {
                if (word != "" && word != " ")
                {
                    check = new List<char>();
                    foreach (char curr in word)
                    {
                        if (((curr >= 65 && curr <= 90) || (curr >= 97 && curr <= 122)) || (curr >= 128 && curr <= 175))
                        {
                            check.Add(curr);
                        }
                    }
                    string add = new string(check.ToArray());

                    if (dictionary.Keys.Contains(add))
                    {
                        dictionary[add]++;
                    }
                    else
                    {
                        dictionary.Add(add, 1);
                    }
                }
            }
            return dictionary;
        }
    }
}
