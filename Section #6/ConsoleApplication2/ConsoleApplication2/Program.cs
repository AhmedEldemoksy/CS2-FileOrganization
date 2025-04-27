using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static int SimpleHash(string s, string[] arr)
        {
            int index = 0;
            foreach (char c in s)
            {
                index += (int)c;
            }
            return index % (arr.Length - 1);
        }

        static int BetterHash(string s, string[] arr)
        {
            int index = 0;
            foreach (char c in s)
            {
                index = (index * 37) + (int)c;
            }
            index %= arr.Length - 1;
            if (index < 0)
            {
                index += arr.Length - 1;
            }
            return index;
        }

        static void Main(string[] args)
        {
            string[] arr = { "apple", "banana", "cherry", "date", "elderberry", "fig", "grape" };

            string testString = "example";

            int simpleHashIndex = SimpleHash(testString, arr);
            int betterHashIndex = BetterHash(testString, arr);

            Console.WriteLine($"Simple hash index for \"{testString}\": {simpleHashIndex}");
            Console.WriteLine($"Better hash index for \"{testString}\": {betterHashIndex}");
        }
    }
}
