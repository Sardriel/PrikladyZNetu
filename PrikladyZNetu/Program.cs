using System;
using System.Linq;
namespace PrikladyZNetu
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Reverse the Odd Length Words
            ///Given a string, reverse all the words which have odd length. The even length words are not changed.
            Console.WriteLine("Write the words.");
            string[] words = Console.ReadLine().Split(" ");
            ReversetheOddLengthWords reversetheOddLengthWords = new ReversetheOddLengthWords();
            reversetheOddLengthWords.Reverse(words);
            


            ///ReverseAndNot
            ///Write a function that takes an integer i and returns a string with the integer backwards followed by the original integer.
            ///i is a non-negative integer.
            ///Bonus: By using System.Linq this should be completed in one line of code. 
            ///ReverseAndNot reverseAndNot = new ReverseAndNot();
            ///reverseAndNot.DoReverseAndAddNotReverse();


            ///Positive Count / Negative Sum
            ///Create a function that takes an array of positive and negative numbers. Return an array where the first element is the count of positive numbers and the second element is the sum of negative numbers.
            ///If given an empty array, return an empty array: []
            ///Cast sum to int, don't mind the remaining decimal places.
            ///0 is not positive.
            ///PositiveCountNegativeSum positiveCountNegativeSum = new PositiveCountNegativeSum();
            ///Console.WriteLine(positiveCountNegativeSum.CountPositiveSumNegative());
            ///Console.ReadKey();

            ///Return the Highest and Lowest Numbers
            ///Create a function that accepts a string of space separated numbers and returns the highest and lowest number (as a string).
            ///All numbers are valid Int32, no need to validate them.
            ///There will always be at least one number in the input string.
            ///Output string must be two numbers separated by a single space, and highest number is first.
            ///Console.WriteLine("Enter space separated numbers:");
            ///string[] numberInput = Console.ReadLine().Split(" ");
            ///ReturnTheHighestAndLowestNumbers returnTheHighestAndLowestNumbers = new ReturnTheHighestAndLowestNumbers();
            ///Console.WriteLine(returnTheHighestAndLowestNumbers.ReturnHighLow(numberInput));
            ///Console.ReadKey();

            ///ATM PIN Code Validation
            ///ATM machines allow 4 or 6 digit PIN codes and PIN codes cannot contain anything but exactly 4 digits or exactly 6 digits. 
            ///Your task is to create a function that takes a string and returns true if the PIN is valid and false if it's not.
            ///Some test cases contain special characters.
            ///Empty strings must return false.
            ///Console.WriteLine("Enter the PIN: (4 or 6 digit):");
            ///string pinCode = Console.ReadLine();
            ///AtmPinCodeValidation atmPinCodeValidation = new AtmPinCodeValidation();
            ///Console.WriteLine(atmPinCodeValidation.AtmValidation(pinCode));
            ///Console.ReadKey();

            ///Find the Characters Counterpart Char Code
            ///Create a function that takes a single character as an argument and returns the char code of its lowercased / uppercased counterpart.
            ///The argument will always be a single character.
            ///Not all inputs will have a counterpart(e.g.numbers), in which case return the input's char code.
            ///Console.WriteLine("Enter character: ");
            ///char character = (char)Console.Read();
            ///FindTheCharactersCounterpartCharCode findTheCharactersCounterpartCharCode = new FindTheCharactersCounterpartCharCode();
            ///Console.WriteLine(findTheCharactersCounterpartCharCode.FindTheCounterPart(character));

            ///Fraction Greater Than One
            ///Given a fraction as a string, return whether or not it is greater than 1 when evaluated.
            ///Console.WriteLine("Enter the fraction you want to compare with one:");
            ///string fraction = Console.ReadLine();
            ///GreaterThanOne greaterThanOne = new GreaterThanOne();
            ///Console.WriteLine(greaterThanOne.CheckGreaterThanOne(fraction));
            ///Console.ReadKey();

            ///Check if a Number is Prime
            ///Create a function that returns true if a number is prime, and false otherwise. A prime number is any positive integer that is evenly divisible by only two divisors: 1 and itself.
            ///Console.WriteLine("Write a number: ");
            ///int number = int.Parse(Console.ReadLine());
            ///IsPrime isPrime = new IsPrime();
            ///Console.WriteLine(isPrime.IsThatNumberPrime(number));
            ///Console.ReadKey();

            ///Reverse the Case
            ///Given a string, create a function to reverse the case. All lower-cased letters should be upper-cased, and vice versa.
            ///Console.WriteLine("Type the sentence for which you want to change case:");
            ///string vetaOriginal = Console.ReadLine();
            ///ReverseTheCase reverseTheCase = new ReverseTheCase();
            ///Console.WriteLine(reverseTheCase.ReversingTheCase(originalSentence));
            ///Console.ReadKey();

            ///Find the bomb
            ///Create a function that finds the word "bomb" in the given string (not case sensitive). If found, return "Duck!!!", otherwise, return "There is no bomb, relax.".
            ///Console.WriteLine("Write the sentece:");
            ///string sentece = Console.ReadLine();
            ///FindTheBomb findTheBomb = new FindTheBomb();
            ///Console.WriteLine(findTheBomb.FindBomb(sentece));
            ///Console.ReadKey();

            ///Multiples
            ///Create a function that takes two numbers as arguments (num, length) and returns an array of multiples of num until the array length reaches length.
            ///Console.WriteLine("Enter the length of array:");
            ///int arrayLength = int.Parse(Console.ReadLine());
            ///Console.WriteLine("Enter the number you want to multiply:");
            ///int multiple = int.Parse(Console.ReadLine());
            ///Multiples multiples = new Multiples();
            ///Console.WriteLine(multiples.CreateMultiple(arrayLength, multiple));
            ///Console.ReadKey();
        }
    }
}
