using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeWithMoshExercises.ArraysAndLists
{
    class ArrayListExercises
    {
        public static void FacebookPost()
        {
            var names = new List<string>();
            var input = "";
            while (input == "")
            {
                Console.Write("Enter a name:> ");
                input = Console.ReadLine();
                names.Add(input);
            }

            foreach (var name in names)
                Console.WriteLine(name);
        }
    }
}
