using System;
using System.IO;

class RepeatNumberTest
{
    static void Main(string[] args)
    {
        RunTests();
    }

    static void RunTests()
    {
        TestRepeatNumber(25,
@"25 25 25 25
25252525
25 25 25 25
25252525", "Test_25");

        TestRepeatNumber(0,
@"0 0 0 0
0000
0 0 0 0
0000", "Test_Zero");

        TestRepeatNumber(7,
@"7 7 7 7
7777
7 7 7 7
7777", "Test_SingleDigit");

        TestRepeatNumber(123,
@"123 123 123 123
123123123123
123 123 123 123
123123123123", "Test_TripleDigit");
    }

    static void TestRepeatNumber(int number, string expected, string testName)
    {
        var output = new StringWriter();
        var originalOut = Console.Out;
        Console.SetOut(output);

        PrintRepeatedNumber(number);

        Console.Out.Flush();
        Console.SetOut(originalOut);

        string actual = output.ToString().Trim();

        if (actual == expected)
            Console.WriteLine($"{testName} ✅ PASSED");
        else
            Console.WriteLine($"{testName} ❌ FAILED\nExpected:\n{expected}\nGot:\n{actual}");
    }

    static void PrintRepeatedNumber(int number)
    {
        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine($"{number} {number} {number} {number}");
            Console.WriteLine($"{number}{number}{number}{number}");
        }
    }
}
