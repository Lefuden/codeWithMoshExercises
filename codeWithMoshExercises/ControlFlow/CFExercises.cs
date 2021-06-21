using System;

namespace codeWithMoshExercises.ControlFlow
{
    public class ControlFlowExercises
    {
        public static void ExerciseOne()
        {
            Console.Write("Enter a number between 1-10:> ");
            var number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number between 1-10:> ");
            var numberTwo = Convert.ToInt32(Console.ReadLine());
            {
                Console.WriteLine("Your first number is " + (number >= 1 && number <= 10 ? "valid." : "invalid."));
                Console.WriteLine("Your second number is " + (numberTwo >= 1 && numberTwo <= 10 ? "valid." : "invalid."));
                Console.WriteLine("\nThe sum of your two numbers is: " + (number + numberTwo));
            }
            Console.Write("Enter the width of a picture:> ");
            number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the height of a picture:> ");
            numberTwo = Convert.ToInt32(Console.ReadLine());
            {
                Console.WriteLine("\nYour picture is in " + (number > numberTwo ? "landscape." : "portrait."));
            }
        }
        public static void SpeedCamera()
        {
            Console.Write("Enter speed limit:> ");
            var speedLimit = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter speed of car:> ");
            var carSpeed = Convert.ToInt32(Console.ReadLine());

            if (carSpeed < speedLimit)
                Console.WriteLine("You're driving within the speed limit.");
            else if (carSpeed > speedLimit)
            {
                int i = 0, demeritPoints = 0;
                var overLimit = carSpeed - speedLimit;

                while (i < overLimit)
                    i += 5; demeritPoints++;

                if (demeritPoints >= 12)
                    Console.WriteLine("License suspended, you madlad!");
                else
                    Console.WriteLine("You've earned " + demeritPoints + " demerit points.");
            }
            else
                Console.WriteLine("You're driving within the speed limit.");
        }
        public static void SpeedCameraTwo()
        {
            Console.Write("Enter speed limit:> ");
            var speedLimit = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter speed of car:> ");
            var carSpeed = Convert.ToInt32(Console.ReadLine());
            var demeritPoints = Convert.ToInt32((Math.Abs(carSpeed) - speedLimit) / 5);
            string outputString = demeritPoints switch
            {
                >= 12 => "License suspended, you madlad!",
                > 0 => "You've earned " + demeritPoints + " demerit points.",
                _ => carSpeed < 0
                    ? "You're driving on the wrong side of the road, the police has been called and your license will be revoked, you dimwit."
                    : "You're driving within the speed limit."
            };
            Console.WriteLine(outputString);
        }
        //public static void SpeedCameraTwo()
        //{
        //    Console.Write("Enter speed limit:> ");
        //    var speedLimit = Convert.ToInt32(Console.ReadLine());
        //    Console.Write("Enter speed of car:> ");
        //    var carSpeed = Convert.ToInt32(Console.ReadLine());
        //    var demeritPoints = Convert.ToInt32((Math.Abs(carSpeed) - speedLimit) / 5);
        //    string outputString;
        //    if (demeritPoints >= 12)        outputString = "License suspended, you madlad!";
        //    else if (demeritPoints > 0)     outputString = "You've earned " + demeritPoints + " demerit points.";
        //    else if (carSpeed < 0)          outputString = "You're driving on the wrong side of the road, the police has been called and your license will be revoked, you dimwit.";
        //    else                            outputString = "You're driving within the speed limit.";
        //    Console.WriteLine(outputString);
        //}
    }
}
