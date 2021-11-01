using System;

namespace FirstOrLasr
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kusib kasutajal sisestada ees-ja perekonnanime
            //programm kontrollib andmete pikkust
            //programm kuvab kumb nendest on pikem, kas ees-voi perekonnanimi

            Console.WriteLine("Sisesta eesnimi:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Sisesta perekonnanimi:");
            string lastName = Console.ReadLine();

            if (firstName.Length > lastName.Length)
            {
                Console.WriteLine("Sinu eesnimi on pikem.");
            }

            else
            {
                Console.WriteLine("Sinu perekonnanimi on pikem");
            }
        }
    }
}
