using System;
using System.IO;
using System.Globalization;

class AverageOfFourNumber
{
    static void Main(string[] args)
    {
        RunTests();
    }

    static void RunTests()
    {
        Test_Average_NormalNumbers();
        Test_Average_WithZeros();
        Test_Average_WithNegatives();
        Test_Average_AllSame();
        Test_Average_WithDecimals();
    }

    static void Test_Average_NormalNumbers()
    {
        RunTestCase(10, 15, 20, 30, "Average: 18.75", "Test_Average_NormalNumbers");
    }

    static void Test_Average_WithZeros()
    {
        RunTestCase(0, 0, 0, 0, "Average: 0", "Test_Average_WithZeros");
    }

    static void Test_Average_WithNegatives()
    {
        RunTestCase(-10, -20, -30, -40, "Average: -25", "Test_Average_WithNegatives");
    }

    static void Test_Average_AllSame()
    {
        RunTestCase(5, 5, 5, 5, "Average: 5", "Test_Average_AllSame");
    }

    static void Test_Average_WithDecimals()
    {
        RunTestCase(1, 2, 3, 4, "Average: 2.5", "Test_Average_WithDecimals");
    }

    static void RunTestCase(double a, double b, double c, double d, string expected, string testName)
    {
        var output = new StringWriter();
        var originalOut = Console.Out;
        Console.SetOut(output);

        PrintAverage(a, b, c, d);

        Console.Out.Flush();
        Console.SetOut(originalOut);

        string actual = output.ToString().Trim();

        if (actual == expected)
            Console.WriteLine($"{testName} ✅ PASSED");
        else
            Console.WriteLine($"{testName} ❌ FAILED\nExpected:\n{expected}\nGot:\n{actual}");
    }

    static void PrintAverage(double a, double b, double c, double d)
    {
        Console.WriteLine($"Average: {(a + b + c + d) / 4}");
    }
}
