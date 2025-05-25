using System;
using System.IO;

class ArithmeticOps
{
    static void Main(string[] args)
    {
        RunTests();
    }

    static void RunTests()
    {
        Test_StandardPositiveInput();
        Test_NegativeSecondNumber();
        Test_ZeroSecondNumber();
        Test_BothNegative();
        Test_ZeroFirstNumber();
    }

    static void Test_StandardPositiveInput()
    {
        RunTestCase(25, 4,
@"25 + 4 = 29
25 - 4 = 21
25 x 4 = 100
25 / 4 = 6
25 mod 4 = 1", "Test_StandardPositiveInput");
    }

    static void Test_NegativeSecondNumber()
    {
        RunTestCase(10, -3,
@"10 + -3 = 7
10 - -3 = 13
10 x -3 = -30
10 / -3 = -3
10 mod -3 = 1", "Test_NegativeSecondNumber");
    }

    static void Test_ZeroSecondNumber()
    {
        RunTestCase(10, 0,
@"10 + 0 = 10
10 - 0 = 10
10 x 0 = 0
Cannot divide by zero
Cannot mod by zero", "Test_ZeroSecondNumber");
    }

    static void Test_BothNegative()
    {
        RunTestCase(-15, -5,
@"-15 + -5 = -20
-15 - -5 = -10
-15 x -5 = 75
-15 / -5 = 3
-15 mod -5 = 0", "Test_BothNegative");
    }

    static void Test_ZeroFirstNumber()
    {
        RunTestCase(0, 3,
@"0 + 3 = 3
0 - 3 = -3
0 x 3 = 0
0 / 3 = 0
0 mod 3 = 0", "Test_ZeroFirstNumber");
    }

    static void RunTestCase(int a, int b, string expected, string testName)
    {
        var output = new StringWriter();
        var standardOut = Console.Out;
        Console.SetOut(output);

        PrintArithmeticOps(a, b);

        Console.Out.Flush();
        string consoleOutput = output.ToString().Trim();
        Console.SetOut(standardOut);

        if (consoleOutput == expected)
            Console.WriteLine($"{testName} ✅ PASSED");
        else
            Console.WriteLine($"{testName} ❌ FAILED\nExpected:\n{expected}\nGot:\n{consoleOutput}");
    }

    static void PrintArithmeticOps(int a, int b)
    {
        Console.WriteLine($"{a} + {b} = {a + b}");
        Console.WriteLine($"{a} - {b} = {a - b}");
        Console.WriteLine($"{a} x {b} = {a * b}");
        
        if (b != 0)
        {
            Console.WriteLine($"{a} / {b} = {a / b}");
            Console.WriteLine($"{a} mod {b} = {a % b}");
        }
        else
        {
            Console.WriteLine($"Cannot divide by zero");
            Console.WriteLine($"Cannot mod by zero");

        }
    }
}
