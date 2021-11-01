using System;

namespace HelloWorldReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab lause "Hello, World!" tagurpidi

            Console.WriteLine("Sisesta lause:");
            string lause = Console.ReadLine();

            for (int i = lause.Length - 1; i >= 0; i--)
            {
                Console.Write(lause[i]);
            }
        }
    }
}
