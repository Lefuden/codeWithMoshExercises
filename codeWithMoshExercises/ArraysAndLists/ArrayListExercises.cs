using System;
using System.Collections.Generic;

namespace codeWithMoshExercises.ArraysAndLists
{
    class ArrayListExercises
    {
        public static void FacebookPost()
        {
            var names = new List<string>();
            while (true)
            {
                Console.Write("Enter a name or press ENTER to stop:> ");
                var input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                    break;    
                names.Add(input);    
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
                                                                //var names = new List<string>();
                                                                //string input = null;
                                                                //while (input != "")
                                                                //{
                                                                //    Console.Write("Enter a name or press ENTER to stop:> ");
                                                                //    input = Console.ReadLine();
                                                                //    if (input != "")
                                                                //        names.Add(input);
                                                                //    else
                                                                //        break;}
        public static void ReverseName()
        {
            Console.Write("Enter your name:> ");
            var name = Console.ReadLine();
            
            var array = new char[name.Length];                  //create char-based array, (name = Console.ReadLine) sets the length of the array.
            
            for (var i = name.Length; i > 0; i--)               //make for loop. i variable used to step through the length of the input data "name"
            {
                var stepsFromLeft = name.Length - i;            //for clarification: stepsFromLeft takes the value in for(name.Length) for easier reading. not necessary.
                var stepsFromRight = i - 1;                     //same idea here.
                array[stepsFromLeft] = name[stepsFromRight];    //same as array[name.Length - i] = name[i -1]. 
            }
            
            var reversed = new string(array);                   //create string-based list of variable array, named reversed.
            Console.WriteLine("Reversed: " + reversed);         //print new result. name reversed. 
        }
                                                                //    Nicer looking code:
                                                                //    Console.Write("What's your name? ");
                                                                //    var name = Console.ReadLine();
                                                                //    var array = new char[name.Length];
                                                                //    for (var i = name.Length; i > 0; i--)
                                                                //        array[name.Length - i] = name[i - 1];
                                                                //    var reversed = new string(array);
                                                                //    Console.WriteLine("Reversed name: " + reversed);
        public static void UniqueNumbers()
        {

        }
    }
}
