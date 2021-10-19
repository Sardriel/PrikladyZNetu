using System;

namespace PrikladyZNetu
{
    class Program
    {
        static void Main(string[] args)
        {
            FindTheBomb findbomb = new FindTheBomb();
            Console.WriteLine("Write the sentense:");
            string reseni = findbomb.FindBomb(Console.ReadLine());
            Console.WriteLine(reseni);
        }
    }
}
