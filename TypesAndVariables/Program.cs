// Official C# Language Site
// https://dotnet.microsoft.com/en-us/learn/csharp

// Single-line comment

/*
    Multi-line comment
    ----------------
    Write your first application: https://aka.ms/dotnet-hello-world
    Discover what's new: https://aka.ms/dotnet-whats-new
    Explore the documentation: https://aka.ms/dotnet-docs
    Report issues and find the source on GitHub: https://github.com/dotnet/core
*/

/// <summary>
/// This is an XML Documentation comment
/// </summary>

// C# Code Conventions
// https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/identifier-names
// Use PascalCase for class names and method names.
// Use camelCase for method arguments, local variables, and private fields.
// Use PascalCase for constant names, both fields and local constants.
var myVariable = "String Type Variable";
Console.WriteLine(myVariable);

// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/const
const string MyConstant = "Constant: a variable that cannot change its value";
Console.WriteLine(MyConstant);

// Primitive data types

// Integer numeric types
// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/integral-numeric-types
int integerNumber = 512;
long longNumber = 12345690123456L;
short shortNumber = 12;
byte byteNumber = 165;

// Floating point numeric types
// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types
float floatNumber = 3.14f;
double doubleNumber = 3.14159265359;
decimal decimalNumber = 123.456m;

// Character type
// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/char
char character = 'A';

// Boolean type
// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool
bool isTrue = true;

// Null reference
string? nullReference = null;

// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/reference-types#the-string-type
string stringCharacters = "AngelSanchezT";

string languageName = "C#";
Console.WriteLine($"Hello, {languageName}!");


// Print values of the variables
Console.WriteLine($"integerNumber: {integerNumber}");
Console.WriteLine($"longNumber: {longNumber}");
Console.WriteLine($"shortNumber: {shortNumber}");
Console.WriteLine($"byteNumber: {byteNumber}");
Console.WriteLine($"floatNumber: {floatNumber}");
Console.WriteLine($"doubleNumber: {doubleNumber}");
Console.WriteLine($"decimalNumber: {decimalNumber}");
Console.WriteLine($"character: {character}");
Console.WriteLine($"isTrue: {isTrue}");
Console.WriteLine($"nullReference: {nullReference}");
Console.WriteLine($"stringCharacters: {stringCharacters}");
