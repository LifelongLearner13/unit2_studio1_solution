using System;

namespace studio1_solution
{
    class Program
    {
        /* Reduce duplication of code */
        static string UserPrompt()
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Radius of the circle ('q' to quite)?");
            return Console.ReadLine();
        }

        static void Main(string[] args)
        {
            string userInput = UserPrompt();

            /* Using a `while` over a `do - while` to allow user to quit before entering first values */
            while (!userInput.ToLower().Equals("q"))
            {
                double num;
                while(userInput.Equals("") || !Double.TryParse(userInput, out num))
                {
                    Console.WriteLine("Must be a valid number.");

                    userInput = UserPrompt();
                }

                double r = Double.Parse(userInput);

                while(r < 0.0)
                {
                    Console.WriteLine("Must be a positive number.");

                    userInput = UserPrompt();
                    r = Double.Parse(userInput);
                }

                Console.WriteLine("The area of the circle is: " + Circle.Area(r));
                Console.WriteLine("The circumference of the circle is: " + Circle.Circumference(r));
                Console.WriteLine("The diameter of the circle is: " + Circle.Diameter(r));

                Console.WriteLine("How many miles per gallon does your car get?");
                string mpgString = Console.ReadLine();
                double mpg = Double.Parse(mpgString);

                double gallonsUsed = Circle.Circumference(r) / mpg;
                Console.WriteLine("You need " + gallonsUsed + " gallons to travel around this circle");

                /* Setup for next loop */
                userInput = UserPrompt();
            }
        }
    }
}
