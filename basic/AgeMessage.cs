using System;
using System.IO;

class AgeMessageTest
{
    static void Main(string[] args)
    {
        RunTests();
    }

    static void RunTests()
    {
        TestAgeMessage(25, "You look older than 25", "Test_Age25");
        TestAgeMessage(0, "You look older than 0", "Test_AgeZero");
        TestAgeMessage(1, "You look older than 1", "Test_AgeOne");
        TestAgeMessage(100, "You look older than 100", "Test_AgeCentenarian");
        TestAgeMessage(-5, "You look older than -5", "Test_NegativeAge");
    }

    static void TestAgeMessage(int age, string expected, string testName)
    {
        var output = new StringWriter();
        var originalOut = Console.Out;
        Console.SetOut(output);

        PrintAgeMessage(age);

        Console.Out.Flush();
        Console.SetOut(originalOut);

        string actual = output.ToString().Trim();

        if (actual == expected)
            Console.WriteLine($"{testName} ✅ PASSED");
        else
            Console.WriteLine($"{testName} ❌ FAILED\nExpected: {expected}\nGot:      {actual}");
    }

    static void PrintAgeMessage(int age)
    {
        Console.WriteLine($"You look older than {age}");
    }
}
