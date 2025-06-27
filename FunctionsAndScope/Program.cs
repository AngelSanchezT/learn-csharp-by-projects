/*
 * EXERCISE:
 * - Create examples of basic functions that represent the different
 *   possibilities of the language:
 *   Without parameters or return, with one or more parameters, with return...
 * - Check if you can create functions inside functions.
 * - Use some example of built-in language functions.
 * - Test the concept of LOCAL and GLOBAL variables.
 * - You must print to the console the result of all the examples.
 *   (and keep in mind that each language may have more or fewer possibilities)
 *
 * EXTRA DIFFICULTY (optional):
 * Create a function that receives two string parameters and returns a number.
 * - The function prints all numbers from 1 to 100. Taking into account that:
 *   - If the number is a multiple of 3, show the string from the first parameter.
 *   - If the number is a multiple of 5, show the string from the second parameter.
 *   - If the number is a multiple of 3 and 5, show both strings concatenated.
 *   - The function returns the number of times the number itself has been printed instead of the texts.
 *
 * Pay special attention to the syntax you must use in each case.
 * Each language follows conventions that you must respect so that the code is understandable.
 */
using System;
class Program
{
    public static string GlobalVariable = "Roadmap_02";

    // Functions without parameters and without return value
    static void FunctionNoParamsNoReturn()
    {
        Console.WriteLine("Function without parameters and without return");
    }

    // Functions without parameters but with return value
    static string FunctionNoParamsWithReturn()
    {
        return "Function without parameters and with return";
    }

    // Functions with parameters but without return value
    static void FunctionWithParamsNoReturn(int a, int b)
    {
        Console.WriteLine($"Function with parameters and no return: sum {a} + {b} = {a + b}");
    }

    // Functions with parameters and return value
    static string FunctionWithParamsWithReturn(string firstName, string lastName)
    {
        return $"Hello {firstName} {lastName}";
    }

    // Functions inside a function
    static void Calculator(int a, int b)
    {
        int Sum(int a, int b)
        {
            return a + b;
        }

        int Subtract(int a, int b)
        {
            return a - b;
        }

        int Multiply(int a, int b)
        {
            return a * b;
        }

        float Divide(int a, int b)
        {
            return a / b;
        }

        Console.WriteLine($"Sum : {a} + {b} = {Sum(a, b)}");
        Console.WriteLine($"Subtract : {a} - {b} = {Subtract(a, b)}");
        Console.WriteLine($"Multiply : {a} * {b} = {Multiply(a, b)}");
        Console.WriteLine($"Divide : {a} / {b} = {Divide(a, b)}");
    }

    public static int ExtraChallenge(string str1, string str2)
    {
        int numberCount = 0;

        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine($"{str1} {str2}");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine(str1);
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine(str2);
            }
            else
            {
                Console.WriteLine(i);
                numberCount++;
            }
        }

        return numberCount;
    }

    static void Main(string[] args)
    {
        FunctionNoParamsNoReturn();

        string result1 = FunctionNoParamsWithReturn();
        Console.WriteLine(result1);

        FunctionWithParamsNoReturn(5, 12);

        string result2 = FunctionWithParamsWithReturn("Jhon", "Smith");
        Console.WriteLine(result2);

        Calculator(5, 12);

        // Lambda function
        // A lambda function is an anonymous function that can contain expressions and statements.
        // It can be used to create delegates or expression tree types.
        // Here we define a lambda function that squares a number
        // and assign it to a variable.
        Func<int, int> square = x => x * x;
        Console.WriteLine(square(9));

        // Built-in language function
        string alphabet = "ABCDEFGHIJKLMNOPQRSTVWYZ";
        Console.WriteLine(alphabet.ToLower());

        // Global variable
        Console.WriteLine(GlobalVariable);

        // Local variables
        static void LocalVariables()
        {
            int a = 1;
            int b = 2;
            Console.WriteLine($"{a} + {b} = {a + b}");
        }

        LocalVariables();

        string s1 = "fizz", s2 = "buzz";
        Console.WriteLine($"\n\nThe number has appeared {ExtraChallenge(s1, s2)} times");
    }
}