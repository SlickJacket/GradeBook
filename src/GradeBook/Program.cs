using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {

            var book = new Book("Bobby's Grade Book");

            while (true)
            {
                Console.WriteLine("Enter a Grade or Enter a 'Q' to quit");
                var input = Console.ReadLine();
                if (input == "Q")
                {
                    Console.WriteLine("You just Quit, Thank you");
                    break;
                }

                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);   
                }
                catch(ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch(FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                // finally
                // {
                //     Console.WriteLine("**");
                // }
                


            }

            var stats = book.GetStatistics();

            // Console.WriteLine($"The added result is {result.Average:N2}");
            Console.WriteLine($"The average is {stats.Average:N2}");
            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"The lowest grade is {stats.Low}");
            Console.WriteLine($"The letter grade is {stats.Letter}");

            // initializing an array
            // var numbers = new[] { 24.2, 12.1, 21.3, 14.1 };

            // initializings a list
            // var grades = new List<double>() { 24.2, 12.1, 21.3, 14.1 };
            // grades.Add(34.5);
        }
    }
}
