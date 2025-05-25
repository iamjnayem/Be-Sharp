using System;
using System.IO;

class MultiplicationTableTest
{
    static void Main(string[] args)
    {
        RunTests();
    }

    static void RunTests()
    {
        Test_TableOfFive();
        Test_TableOfZero();
        Test_TableOfNegativeNumber();
        Test_TableOfOne();
    }

    static void Test_TableOfFive()
    {
        RunTestCase(5,
@"5 * 0 = 0
5 * 1 = 5
5 * 2 = 10
5 * 3 = 15
5 * 4 = 20
5 * 5 = 25
5 * 6 = 30
5 * 7 = 35
5 * 8 = 40
5 * 9 = 45
5 * 10 = 50", "Test_TableOfFive");
    }

    static void Test_TableOfZero()
    {
        RunTestCase(0,
@"0 * 0 = 0
0 * 1 = 0
0 * 2 = 0
0 * 3 = 0
0 * 4 = 0
0 * 5 = 0
0 * 6 = 0
0 * 7 = 0
0 * 8 = 0
0 * 9 = 0
0 * 10 = 0", "Test_TableOfZero");
    }

    static void Test_TableOfNegativeNumber()
    {
        RunTestCase(-3,
@"-3 * 0 = 0
-3 * 1 = -3
-3 * 2 = -6
-3 * 3 = -9
-3 * 4 = -12
-3 * 5 = -15
-3 * 6 = -18
-3 * 7 = -21
-3 * 8 = -24
-3 * 9 = -27
-3 * 10 = -30", "Test_TableOfNegativeNumber");
    }

    static void Test_TableOfOne()
    {
        RunTestCase(1,
@"1 * 0 = 0
1 * 1 = 1
1 * 2 = 2
1 * 3 = 3
1 * 4 = 4
1 * 5 = 5
1 * 6 = 6
1 * 7 = 7
1 * 8 = 8
1 * 9 = 9
1 * 10 = 10", "Test_TableOfOne");
    }

    static void RunTestCase(int n, string expected, string testName)
    {
        var output = new StringWriter();
        var originalOut = Console.Out;
        Console.SetOut(output);

        PrintMultiplicationTable(n);

        Console.Out.Flush();
        Console.SetOut(originalOut);

        string actual = output.ToString().Trim();

        if (actual == expected)
            Console.WriteLine($"{testName} ✅ PASSED");
        else
            Console.WriteLine($"{testName} ❌ FAILED\nExpected:\n{expected}\nGot:\n{actual}");
    }

    static void PrintMultiplicationTable(int n)
    {
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine($"{n} * {i} = {n * i}");
        }
    }
}
