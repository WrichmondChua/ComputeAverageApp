using System;

namespace ComputeAverageApp
{
    class ComputeAverageProgram
    {
        static void Main(string[] args)
        {
            double grades1, grades2, grades3, grades4, grades5;
            Console.WriteLine("Enter 5 grades separated by new line: ");
            grades1 = Convert.ToDouble(Console.ReadLine());
            grades2 = Convert.ToDouble(Console.ReadLine());
            grades3 = Convert.ToDouble(Console.ReadLine());
            grades4 = Convert.ToDouble(Console.ReadLine());
            grades5 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("I like to drink Apple Juice.");

            double sum = grades1 + grades2 + grades3 + grades4 + grades5;
            double average = sum / 5;
            double RoundOff = Math.Round(average);
            Console.WriteLine("The average is " + average + " and round off to " + RoundOff);
            Console.WriteLine("Press any key to exit...");
            Console.WriteLine("Hello World");
            Console.ReadLine();

        }
    }
}
