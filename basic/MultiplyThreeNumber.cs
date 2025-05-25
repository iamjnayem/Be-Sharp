using System;
using System.IO;

class MultiplyThreeNumber
{
    static void Main(string[] args)
    {
        RunTests();
    }

    static void RunTests()
    {
        Test_Multiply_PositiveNumbers();
        Test_Multiply_WithZero();
        Test_Multiply_NegativeNumbers();
        Test_Multiply_AllZeros();
        Test_Multiply_MixedSigns();
    }

    static void Test_Multiply_PositiveNumbers()
    {
        RunTestCase(2, 3, 6, "2 x 3 x 6 = 36", "Test_Multiply_PositiveNumbers");
    }

    static void Test_Multiply_WithZero()
    {
        RunTestCase(5, 0, 10, "5 x 0 x 10 = 0", "Test_Multiply_WithZero");
    }

    static void Test_Multiply_NegativeNumbers()
    {
        RunTestCase(-2, -3, -1, "-2 x -3 x -1 = -6", "Test_Multiply_NegativeNumbers");
    }

    static void Test_Multiply_AllZeros()
    {
        RunTestCase(0, 0, 0, "0 x 0 x 0 = 0", "Test_Multiply_AllZeros");
    }

    static void Test_Multiply_MixedSigns()
    {
        RunTestCase(-2, 4, -3, "-2 x 4 x -3 = 24", "Test_Multiply_MixedSigns");
    }

    static void RunTestCase(int a, int b, int c, string expected, string testName)
    {
        var output = new StringWriter();
        var standardOut = Console.Out;
        Console.SetOut(output);

        MultiplyAndPrint(a, b, c);

        Console.Out.Flush();
        string consoleOutput = output.ToString().Trim();
        Console.SetOut(standardOut);

        if (consoleOutput == expected)
            Console.WriteLine($"{testName} ✅ PASSED");
        else
            Console.WriteLine($"{testName} ❌ FAILED\nExpected: {expected}\nGot: {consoleOutput}");
    }

    static void MultiplyAndPrint(int a, int b, int c)
    {
        // -2 x 4 x - 3 = 24
        Console.WriteLine($"{a} x {b} x {c} = {a * b * c}");
    }
}
