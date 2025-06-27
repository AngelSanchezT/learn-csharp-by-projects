/*
 * EXERCISE:
 * - Create examples using all types of operators in your language:
 *   Arithmetic, logical, comparison, assignment, identity, membership, bitwise...
 *   (Keep in mind that each language may have different ones)
 * - Using operations with any operators you want, create examples
 *   that represent all types of control structures that exist
 *   in your language:
 *   Conditionals, loops, exceptions...
 * - You must print to the console the result of all the examples.
 *
 * EXTRA DIFFICULTY (optional):
 * Create a program that prints to the console all numbers between
 * 10 and 55 (inclusive), that are even, and are neither 16 nor multiples of 3.
 *
 * Surely by carefully reviewing the possibilities you have discovered something new.
 */
using System;
class Program
{
    private static void Main(string[] args)
    {
        // Arithmetic Operators
        Console.WriteLine("Arithmetic Operators:");
        int a = 5;
        int b = 3;
        Console.WriteLine($"Addition: {a + b}");
        Console.WriteLine($"Subtraction: {a - b}");
        Console.WriteLine($"Multiplication: {a * b}");
        Console.WriteLine($"Division: {a / b}");
        Console.WriteLine($"Modulo: {a % b}");
        Console.WriteLine();

        // Logical Operators
        Console.WriteLine("Logical Operators:");
        bool p = true;
        bool q = false;
        Console.WriteLine($"Logical AND: {p && q}");
        Console.WriteLine($"Logical OR: {p || q}");
        Console.WriteLine($"Logical NOT: {!p}");
        Console.WriteLine();

        // Comparison Operators
        Console.WriteLine("Comparison Operators:");
        int x = 10;
        int y = 20;
        Console.WriteLine($"Equal: {x == y}");
        Console.WriteLine($"Not equal: {x != y}");
        Console.WriteLine($"Greater than: {x > y}");
        Console.WriteLine($"Less than: {x < y}");
        Console.WriteLine($"Greater or equal: {x >= y}");
        Console.WriteLine($"Less or equal: {x <= y}");
        Console.WriteLine();

        // Assignment Operators
        Console.WriteLine("Assignment Operators:");
        int z = 7;
        Console.WriteLine($"Before assignment: {z}");
        z += 3;
        Console.WriteLine($"After assignment: {z}");
        Console.WriteLine();

        // Control Structures
        Console.WriteLine("Control Structures:");

        // Conditionals
        if (a > b)
        {
            Console.WriteLine("a is greater than b");
        }
        else
        {
            Console.WriteLine("a is not greater than b");
        }

        // Loops
        Console.WriteLine("For loop:");
        for (int i = 10; i <= 55; i++)
        {
            if (i % 2 == 0 && i != 16 && i % 3 != 0)
            {
                Console.WriteLine(i);
            }
        }

        // Exceptions
        Console.WriteLine("Exception handling:");
        try
        {
            // Simulate an exception (division by zero)
            int result = a / (b - 3);
            Console.WriteLine($"Result: {result}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Exception: {ex.Message}");
        }
    }
}