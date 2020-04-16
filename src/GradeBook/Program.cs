using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 43.2;
            var y = 47.6;
            var added = x + y;

            // initializing an array
            var numbers = new[] { 24.2, 12.1, 21.3, 14.1 };
            // initializings a list
            var grades = new List<double>() { 24.2, 12.1, 21.3, 14.1 };
            grades.Add(34.5);
            var result = 0.0;

            foreach(var num in grades){
                result += num;
            }

            var average = result / grades.Count;
            System.Console.WriteLine(result);
            System.Console.WriteLine(average);

            if (args.Length > 0)
            {
                Console.WriteLine($"Hello {args[0]}! You have {added} apples.");
            }
            else
            {
                Console.WriteLine("Goodbye");
            }
        }
    }
}
