using System;
using System.IO;

class ArithmeticOperations
{
    static void Main(string[] args)
    {
        RunTests();
    }

    static void RunTests()
    {
        TestOperation1();
        TestOperation2();
        TestOperation3();
        TestOperation4();
    }

    static void TestOperation1()
    {
        RunTestCase(Operation1, "23", "TestOperation1: -1 + 4 * 6");
    }

    static void TestOperation2()
    {
        RunTestCase(Operation2, "5", "TestOperation2: (35 + 5) % 7");
    }

    static void TestOperation3()
    {
        RunTestCase(Operation3, "12", "TestOperation3: 14 + -4 * 6 / 11");
    }

    static void TestOperation4()
    {
        RunTestCase(Operation4, "3", "TestOperation4: 2 + 15 / 6 * 1 - 7 % 2");
    }

    static void RunTestCase(Action operationMethod, string expected, string testName)
    {
        var output = new StringWriter();
        var standardOut = Console.Out;
        Console.SetOut(output);

        operationMethod();

        Console.Out.Flush();
        string consoleOutput = output.ToString().Trim();
        Console.SetOut(standardOut);

        if (consoleOutput == expected)
            Console.WriteLine($"{testName} ✅ PASSED");
        else
            Console.WriteLine($"{testName} ❌ FAILED\nExpected: {expected}\nGot: {consoleOutput}");
    }

    static void Operation1()
    {
        Console.WriteLine(-1 + 4 * 6);
    }

    static void Operation2()
    {
        Console.WriteLine((35 + 5) % 7);
    }

    static void Operation3()
    {
        Console.WriteLine(14 + -4 * 6 / 11);
    }

    static void Operation4()
    {
        Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);
    }
}
