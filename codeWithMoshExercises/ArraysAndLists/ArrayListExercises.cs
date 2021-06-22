using System;
using System.Collections.Generic;

namespace codeWithMoshExercises.ArraysAndLists
{
    class ArrayListExercises
    {
        public static void FacebookPost()
        {
            var names = new List<string>();
            string input = null;
            while (input != "")
            {
                Console.Write("Enter a name:> ");
                input = Console.ReadLine();
                if (input != "")
                    names.Add(input);
                else
                    break;
            }
            Console.WriteLine();
            switch (names.Count)
            {
                case 0:
                    Console.WriteLine("No one likes you.");
                    break;
                case 1:
                    Console.WriteLine("{0} likes your post.", names[0]);
                    break;
                case 2:
                    Console.WriteLine("{0} and {1} like your post.", names[0], names[1]);
                    break;
                case > 2:
                    Console.WriteLine("{0}, {1} and {2} others like your post.", names[0], names[1], names.Count -2);
                    break;
            }
        }
    }
}
