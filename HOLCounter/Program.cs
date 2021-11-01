using System;

namespace HOLCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab konsoolis, mitu 'h', 'o' ja 'l' tähte on lauses "Hello World!"

            Console.WriteLine("Sisesta lause");
            string lause = Console.ReadLine().ToLower();

            Console.WriteLine(lause);

            int hCounter = 0;
            int oCounter = 0;
            int lCounter = 0;

            for (int i = 0; i < lause.Length; i++)
            {
                if (lause[i] == 'h')
                {
                    hCounter++;
                }
                else if(lause[i] == 'o')
                {
                    oCounter++;
                }
                else if(lause[i] == 'l')
                {
                    lCounter++;
                }
            }
                Console.WriteLine($"Lauses {lause} on {hCounter} 'h', {oCounter} 'o' ja {lCounter} 'l' tähte.");
         
          
        }
    }
}
