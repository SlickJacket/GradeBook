using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 43.2;
            var y = 47.6;
            var added = x + y;

            if (args.Length > 0)
            {
                Console.WriteLine($"Hello {args[0]}! You have {added} apples.");
            }
            else {
                Console.WriteLine("Goodbye");
            }
        }
    }
}
