using System;

class ToLowercaseTest
{
    static void Main(string[] args)
    {
        RunTests();
    }

    static void RunTests()
    {
        // ✅ Basic cases
        TestToLowercase("HELLO", "hello", "All_Uppercase");
        TestToLowercase("hello", "hello", "All_Lowercase");
        TestToLowercase("HeLLo", "hello", "Mixed_Case");

        // ✅ With numbers and symbols
        TestToLowercase("123ABC!@#", "123abc!@#", "AlphaNum_Symbols");
        TestToLowercase("TeSt123$", "test123$", "Mixed_AlphaNum");

        // ✅ Empty and single char
        TestToLowercase("", "", "Empty_String");
        TestToLowercase("A", "a", "Single_Upper");
        TestToLowercase("z", "z", "Single_Lower");

        // ✅ Unicode & extended chars
        TestToLowercase("ÄBC", "äbc", "Unicode_Capital_A_Umlaut");
        TestToLowercase("Çalış", "çalış", "Turkish_Letters");

        // ✅ Whitespace
        TestToLowercase(" Hello World ", " hello world ", "With_Whitespace");
    }

    static void TestToLowercase(string input, string expected, string testName)
    {
        try
        {
            string actual = ToLowercase(input); // You will implement this

            if (actual == expected)
            {
                Console.WriteLine($"{testName} ✅ PASSED");
            }
            else
            {
                Console.WriteLine($"{testName} ❌ FAILED");
                Console.WriteLine($"  Expected: \"{expected}\", Got: \"{actual}\"");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"{testName} ❌ FAILED with Exception: {ex.Message}");
        }
    }

    // 🔧 Your implementation goes here
    static string ToLowercase(string input)
    {
        return input.ToLower();
    }
}
