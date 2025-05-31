using System;
using System.Globalization;

class AddFirstCharFrontBackTest
{
    static void Main(string[] args)
    {
        RunTests();
    }

    static void RunTests()
    {
        // Sample test
        TestAddFirstCharFrontBack("The quick brown fox jumps over the lazy dog.",
                                  "TThe quick brown fox jumps over the lazy dog.T",
                                  "Sample_1");

        // Edge cases
        TestAddFirstCharFrontBack("x", "xxx", "Single_Char");
        TestAddFirstCharFrontBack("hello", "hhelloh", "Normal_Word");
        TestAddFirstCharFrontBack("🙂hello", "🙂🙂hello🙂", "Emoji_Start");
        TestAddFirstCharFrontBack("👨‍💻code", "👨‍💻👨‍💻code👨‍💻", "ZWJ_Emoji_Start");
        TestAddFirstCharFrontBack(" ", "   ", "Space_Char");
        TestAddFirstCharFrontBack("あいうえお", "ああいうえおあ", "Japanese");

        // Invalid
        TestAddFirstCharFrontBack("", "", "Empty_String"); // Will not throw, just return empty
    }

    static void TestAddFirstCharFrontBack(string input, string expected, string testName)
    {
        try
        {
            string actual = AddFirstCharFrontBack(input);

            if (actual == expected)
            {
                Console.WriteLine($"{testName} ✅ PASSED");
            }
            else
            {
                Console.WriteLine($"{testName} ❌ FAILED");
                Console.WriteLine($"  Expected: '{expected}', Got: '{actual}'");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"{testName} ❌ FAILED with Exception: {ex.Message}");
        }
    }

    static string AddFirstCharFrontBack(string input)
    {
        if (input.Length <= 1)
            return $"{input}{input}{input}";

        StringInfo stringInfo = new StringInfo(input);

        string first = stringInfo.SubstringByTextElements(0, 1);
        return first + input + first;
    }
}
