using System;
using System.IO;
using System.Linq;

class RectanglePatternTest
{
    static void Main(string[] args)
    {
        RunTests();
    }

    static void RunTests()
    {
        TestRectanglePattern(5,
@"555
5 5
5 5
5 5
555", "Test_5");

        TestRectanglePattern(0,
@"000
0 0
0 0
0 0
000", "Test_0");

        TestRectanglePattern(9,
@"999
9 9
9 9
9 9
999", "Test_9");

        TestRectanglePattern(12,
@"121212
12  12
12  12
12  12
121212", "Test_TwoDigit");
    }

    static void TestRectanglePattern(int num, string expected, string testName)
    {
        var output = new StringWriter();
        var originalOut = Console.Out;
        Console.SetOut(output);

        PrintRectanglePattern(num);

        Console.Out.Flush();
        Console.SetOut(originalOut);

        string actual = output.ToString().Trim();

        if (actual == expected)
            Console.WriteLine($"{testName} ✅ PASSED");
        else
            Console.WriteLine($"{testName} ❌ FAILED\nExpected:\n{expected}\nGot:\n{actual}");
    }

    static int CountDigit(int number)
    {
        if (number == 0) return 1;

        int count = 0;
        while (number != 0)
        {
            number = number / 10;
            count++;
        }
        return count;
    }

    static void PrintRectanglePattern(int num)
    {

        string numStr = num.ToString();
        int    width  = numStr.Length;
        string border = string.Concat(Enumerable.Repeat(numStr, 3));
        string middle = $"{numStr}{new string(' ', width)}{numStr}";

        Console.WriteLine(border);
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(middle);
        }
        Console.WriteLine(border);

    }
}
