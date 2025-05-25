using System;
using System.IO;

class DivideTwoNumbers
{
    static void Main(string[] args)
    {
        RunTests();
    }

    static void RunTests()
    {
        TestPrintDivisionResult_Normal();
        TestPrintDivisionResult_DivideByZero();
        TestPrintDivisionResult_NegativeNumbers();
        TestPrintDivisionResult_ZeroNumerator();
        TestPrintDivisionResult_FractionalResult();
    }

    static void TestPrintDivisionResult_Normal()
    {
        RunTestCase(10, 2, "Result: 5", "Normal Division");
    }

    static void TestPrintDivisionResult_DivideByZero()
    {
        RunTestCase(10, 0, "Error: Cannot divide by zero", "Divide By Zero");
    }

    static void TestPrintDivisionResult_NegativeNumbers()
    {
        RunTestCase(-12, 4, "Result: -3", "Negative Numerator");
        RunTestCase(12, -4, "Result: -3", "Negative Denominator");
        RunTestCase(-12, -4, "Result: 3", "Both Negative");
    }

    static void TestPrintDivisionResult_ZeroNumerator()
    {
        RunTestCase(0, 5, "Result: 0", "Zero Numerator");
    }

    static void TestPrintDivisionResult_FractionalResult()
    {
        RunTestCase(7, 2, "Result: 3.5", "Fractional Result");
    }

    static void RunTestCase(int a, int b, string expected, string testName)
    {
        var output = new StringWriter();
        var standardOut = Console.Out;
        Console.SetOut(output);

        PrintDivision(a, b);

        Console.Out.Flush();
        string consoleOutput = output.ToString().Trim();
        Console.SetOut(standardOut);

        if (consoleOutput == expected)
            Console.WriteLine($"{testName} ✅ PASSED");
        else
            Console.WriteLine($"{testName} ❌ FAILED\nExpected: {expected}\nGot: {consoleOutput}");
    }

    static void PrintDivision(int a, int b)
    {
        float aFloat = (float)a;
        float bFloat = (float)b;
        if (b == 0)
        {
            Console.WriteLine("Error: Cannot divide by zero");
            return;
        }

        if (a % b == 0)
        {
            Console.WriteLine($"Result: {a / b}");
            return;
        }

        Console.WriteLine($"Result: {aFloat/bFloat}");

    }
}
