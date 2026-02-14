using System;

namespace BasicCSharpPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Header information
            string studentName = "Jose Gregorio Gonzalez";
            string studentId = "2024-1735";
            string classDay = "Monday";

            Console.WriteLine("Student Information");
            Console.WriteLine($"Name: {studentName}");
            Console.WriteLine($"ID: {studentId}");
            Console.WriteLine($"Class Day: {classDay}");
            Console.WriteLine("----------------------------------");

            // 1. Declare variables of different types, assign values and print them
            int age = 20;
            double salary = 1500.75;
            char grade = 'A';
            bool isActive = true;
            string course = "Software Development";

            Console.WriteLine("Different variable types:");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Salary: {salary}");
            Console.WriteLine($"Grade: {grade}");
            Console.WriteLine($"Is Active: {isActive}");
            Console.WriteLine($"Course: {course}");
            Console.WriteLine("----------------------------------");

            // 2. Declare a constant and print its value
            const double PI = 3.1416;
            Console.WriteLine("Constant value:");
            Console.WriteLine($"PI: {PI}");

            /*
             Trying to change the value of a constant will cause
             a compilation error.
             Example (DO NOT UNCOMMENT):
             PI = 5.5;
            */
            Console.WriteLine("----------------------------------");

            // 3. Declare an integer, increment, decrement and perform operations
            int number = 10;
            number++; // increment
            number--; // decrement

            int sum = number + 5;
            int multiplication = number * 2;

            Console.WriteLine("Integer operations:");
            Console.WriteLine($"Number value: {number}");
            Console.WriteLine($"Sum result: {sum}");
            Console.WriteLine($"Multiplication result: {multiplication}");
            Console.WriteLine("----------------------------------");

            // 4. Declare a float and a byte operation
            float largeFloat = 10152466.25f;

            // Explicit cast is required because byte cannot store float values
            byte byteValue = (byte)(5 + largeFloat);

            Console.WriteLine("Float and byte operation:");
            Console.WriteLine($"Float value: {largeFloat}");
            Console.WriteLine($"Byte result after casting: {byteValue}");
            Console.WriteLine("----------------------------------");

            // 5. Single-line and multi-line comments already included above

            // Print current system date and time
            DateTime currentDateTime = DateTime.Now;
            Console.WriteLine("Current system date and time:");
            Console.WriteLine(currentDateTime);

            Console.ReadKey();
        }
    }
}
