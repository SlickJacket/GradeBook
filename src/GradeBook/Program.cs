using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {

            var book = new Book("Bobby's Grade Book");
            book.AddGrade(44.5);
            book.AddGrade(89.4);
            book.AddGrade(99.4);

            var stats =book.GetStatistics();

            // Console.WriteLine($"The added result is {result.Average:N2}");
            Console.WriteLine($"The average is {stats.Average:N2}");
            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"The lowest grade is {stats.Low}");

            // initializing an array
            // var numbers = new[] { 24.2, 12.1, 21.3, 14.1 };

            // initializings a list
            // var grades = new List<double>() { 24.2, 12.1, 21.3, 14.1 };
            // grades.Add(34.5);
        }
    }
}
