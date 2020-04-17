using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {

        // explicit contructor 
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public void showStatistics()
        {
            var result = 0.0;
            var lowGrade = double.MaxValue;
            var highGrade = double.MinValue;

            foreach (var num in grades)
            {
                highGrade = Math.Max(num, highGrade);
                lowGrade = Math.Min(num, lowGrade);
                result += num;
            }

            var average = result / grades.Count;
            Console.WriteLine($"The added result is {result:N2}");
            Console.WriteLine($"The average is {average}");
            Console.WriteLine($"The highest grade is {highGrade}");
            Console.WriteLine($"The lowest grade is {lowGrade}");
        }

        // fields
        private List<double> grades;
        private string name;
    }
}