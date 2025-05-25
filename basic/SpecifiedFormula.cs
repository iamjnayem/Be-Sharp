using System;
using System.IO;

class SpecifiedFormula
{
    static void Main(string[] args)
    {
        RunTests();
    }

    static void RunTests()
    {
        Test_SpecifiedFormula(5, 6, 7,
            "Result of specified numbers 5, 6 and 7, (x+y).z is 77 and x.y + y.z is 72", "Test_Case1");

        Test_SpecifiedFormula(1, 2, 3,
            "Result of specified numbers 1, 2 and 3, (x+y).z is 9 and x.y + y.z is 8", "Test_Case2");

        Test_SpecifiedFormula(0, 0, 0,
            "Result of specified numbers 0, 0 and 0, (x+y).z is 0 and x.y + y.z is 0", "Test_Case3");

        Test_SpecifiedFormula(-1, 4, 5,
  "Result of specified numbers -1, 4 and 5, (x+y).z is 15 and x.y + y.z is 16", "Test_NegativeX");

        Test_SpecifiedFormula(3, -2, 7,
  "Result of specified numbers 3, -2 and 7, (x+y).z is 7 and x.y + y.z is -20", "Test_NegativeY");
    }

    static void Test_SpecifiedFormula(int x, int y, int z, string expected, string testName)
    {
        var output = new StringWriter();
        var originalOut = Console.Out;
        Console.SetOut(output);

        PrintSpecifiedFormula(x, y, z);

        Console.Out.Flush();
        Console.SetOut(originalOut);

        string actual = output.ToString().Trim();

        if (actual == expected)
            Console.WriteLine($"{testName} ✅ PASSED");
        else
            Console.WriteLine($"{testName} ❌ FAILED\nExpected:\n{expected}\nGot:\n{actual}");
    }

    static void PrintSpecifiedFormula(int x, int y, int z)
    {
        // Result of specified numbers 1, 2 and 3, (x + y).z is 9 and x.y + y.z is 8
        Console.WriteLine($"Result of specified numbers {x}, {y} and {z}, (x+y).z is {(x + y) * z} and x.y + y.z is {x * y + y * z}");
    }
}
