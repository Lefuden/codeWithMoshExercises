using System;

namespace codeWithMoshExercises.Loops
{
    class LoopExercises
    {
        public static void DivideByThree()
        {
            var i = 100;
            var counter = 0;
            while (i > 0)
            {
                if (i % 3 == 0) counter++;
                i--;
            }
            Console.WriteLine("There are {0} numbers divisible by 3 between 1 and 100.", counter);
        }
        public static void CalculateSumOfInput()
        {
            var answer = "";
            var sumTotal = 0;
            while (answer != "ok")
            {
                Console.Write("Enter a number (or 'ok' to exit):> ");
                answer = Console.ReadLine();
                if (answer.ToLower() == "ok") break;
                sumTotal += Convert.ToInt32(answer);
            }
            Console.WriteLine("The sum of your numbers is: {0}", sumTotal);
        }
        public static void ComputeFactorial()
        {
            Console.Write("Enter a number:> ");
            var input = Convert.ToInt64(Console.ReadLine());
            var factorial = input - 1;
            if (factorial <= 0)
            {
                Console.WriteLine("{0}! = {0}", input);
            }
            else
            {
                var sum = factorial * input;
                factorial--;
                while (factorial > 0)
                {
                    sum = factorial * sum;
                    factorial--;
                }
                Console.WriteLine("{0}! = {1}", input, sum);
            }
        }
        public static void ComputeFactorial2()
        {
            Console.Write("Enter a number:> ");
            var input = Convert.ToInt64(Console.ReadLine());
            var counter = 1;
            var output = input;
            while (counter < input)
            {
                output *= (input - counter);
                counter++;
            }
            Console.WriteLine("{0}! = {1}",input, output);
        }
        public static int ComputeFactorial3(int input)
        {
            var output = 1;
            if (input > 1)
                output = ComputeFactorial3(input -1);
            return output * input;
        }
    }
}