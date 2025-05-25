using System;
using System.IO;

class SumOfTwoNumbers
{
    static void Main(string[] args)
    {
        RunTests();
    }

    static void RunTests()
    {
        TestPrintSum();
    }

    static void TestPrintSum()
    {
        var output = new StringWriter();
        var standardOut = Console.Out;
        Console.SetOut(output);

        PrintSum(5, 7);

        Console.Out.Flush();
        string consoleOutput = output.ToString().Trim();
        Console.SetOut(standardOut);

        string expected = "Sum: 12";

        if (consoleOutput == expected)
            Console.WriteLine("TestPrintSum PASSED");
        else
            Console.WriteLine($"TestPrintSum FAILED\nExpected: {expected}\nGot: {consoleOutput}");
    }

    static void PrintSum(int a, int b)
    {
        Console.WriteLine($"Sum: {a + b}");
    }
}
