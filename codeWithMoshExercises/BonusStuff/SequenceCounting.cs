using System;
using System.Data;

namespace codeWithMoshExercises.BonusStuff
{
    class SequenceCounting
    {
        public static void Fibonacci()
        {
            double nr1 = 0, nr2 = 1, sum = nr1 + nr2, counter = 0;
            while (counter < 100)
            {
                Console.WriteLine("{0} + {1} = {2}",nr1,nr2,sum);
                Console.WriteLine(sum/nr2);
                nr1 = nr2;
                nr2 = sum;
                sum = nr1 + nr2;
                counter++;
            }
        }
        public static void CalculateToOne()
        {
            Console.Write("Enter a number:> ");
            var input = Convert.ToInt32(Console.ReadLine());
            var counter = 1;
            while (input != 1)
            {
                if (input % 2 == 0) input /= 2;
                else input = input * 3 + 1;
                Console.WriteLine("Calculation #{0}. Output: {1}",counter, input);
                counter++;
            }
        }
    }
}
/*
För pluspoäng #1: Gör en variant på funktionen som inte skriver ut alla stegen utan bara skriver ut antalet steg som krävs för att nå #1.
För pluspoäng #2: Gör ett program som visar vilket tal under mellan 1-100 som kräver flest steg för att nå 1 och skriv ut de talen.
För pluspoäng #3: Försök hitta en motivering till varför jag sa att du skulle stanna funktionen när den når 1 */