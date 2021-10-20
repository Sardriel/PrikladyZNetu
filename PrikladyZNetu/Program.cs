using System;
using System.Linq;
namespace PrikladyZNetu
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Reverse the Case
            ///Given a string, create a function to reverse the case. All lower-cased letters should be upper-cased, and vice versa.
            Console.WriteLine("Type the sentence for which you want to change case:");
            string vetaOriginal = Console.ReadLine();
            ReverseTheCase reverseTheCase = new ReverseTheCase();
            Console.WriteLine(reverseTheCase.ReversingTheCase(vetaOriginal));
            Console.ReadKey();


            ///Find the bomb
            ///Console.WriteLine("Write the sentece:");
            ///string sentece = Console.ReadLine();
            ///FindTheBomb findTheBomb = new FindTheBomb();
            ///Console.WriteLine(findTheBomb.FindBomb(sentese));
            ///Console.ReadKey();

            ///Multiples
            ///Console.WriteLine("Zadej délku pole:");
            ///int delkaPole = int.Parse(Console.ReadLine());
            ///Console.WriteLine("Zadej číslo, které chceš mít znásobeno v poli:");
            ///int nasobek = int.Parse(Console.ReadLine());
            ///Multiples multiples = new Multiples();
            ///Console.WriteLine(multiples.CreateMultiple(delkaPole, nasobek));
            ///Console.ReadKey();
        }
    }
}
