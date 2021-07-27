using System;

namespace FORLOOPghjkasrowieru
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            for (int i = 0; i < 10; i++) //loops 10 times
            {
                Console.WriteLine(rand.Next(10));
            }
            Console.WriteLine("Damn thats a lot of numbers, thanks for tuning in to this shitty c# program");
        }
    }
}
