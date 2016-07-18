using System;
using Library;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"The answer is {new Thing().Get(19, 23)}");
            for (int i=0; i< 10; ++i) {
                Console.WriteLine("{0}", i);
            }
        }
    }
}
