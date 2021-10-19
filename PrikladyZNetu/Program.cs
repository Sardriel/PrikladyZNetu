using System;

namespace PrikladyZNetu
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Zadej délku pole:");
            int delkaPole = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadej číslo, které chceš mít znásobeno v poli:");
            int nasobek = int.Parse(Console.ReadLine());
            int[] pole = new int[delkaPole];

            for (int i = 0; i < delkaPole; i++)
            {
                pole[i] = (nasobek + nasobek);
                nasobek = nasobek + nasobek;
            }

            foreach (int i in pole)
            {
                Console.WriteLine("{0}", i);
            }

        }
    }
}
