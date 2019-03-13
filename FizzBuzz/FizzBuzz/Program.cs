using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzzKata fizzBuzzKata = new FizzBuzzKata();

            for (int i = 0; i <= 101; i++)
            {
                try
                {
                    Console.WriteLine(fizzBuzzKata.ProcessNumber(i));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
