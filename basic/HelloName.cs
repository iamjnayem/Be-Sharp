using System;
using System.IO;

class HelloName
{
    static void Main(string[] args)
    {
        RunTests();
    }

    static void RunTests()
    {
        TestHelloNameOutput();
    }


    static void TestHelloNameOutput()
    {
        var output = new StringWriter();
        var standardOut = Console.Out;
        Console.SetOut(output);
        HelloNamePrint();
        Console.Out.Flush();
        string consoleOutput = output.ToString().Trim();
        Console.SetOut(standardOut);

        string expected = "Hello: Alexandra Abramov";

        if (consoleOutput == expected)
            Console.WriteLine("TestHelloNameOutput PASSED!!!");
        else
            Console.WriteLine($"TestHelloNameOutput FAILED\nExpected: {expected}\nGot: {consoleOutput}");
    }


    static void HelloNamePrint()
    {
        Console.WriteLine("Hello: Alexandra Abramov");
    }
}
