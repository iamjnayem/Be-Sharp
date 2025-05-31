using System;
using System.Globalization;

class SwapFirstLastCharTest
{
    static void Main(string[] args)
    {
        RunTests();
    }

    static void RunTests()
    {
        // Sample tests
        TestSwapFirstLast("w3resource", "e3resourcw", "Sample_1");
        TestSwapFirstLast("Python", "nythoP", "Sample_2");
        TestSwapFirstLast("x", "x", "Sample_3");

        // Edge cases
        TestSwapFirstLast("", "", "Empty_String");
        TestSwapFirstLast("ab", "ba", "Two_Chars");
        TestSwapFirstLast("aa", "aa", "Same_First_Last");
        TestSwapFirstLast("abcde", "ebcda", "Odd_Length");
        TestSwapFirstLast("abcdef", "fbcdea", "Even_Length");
        TestSwapFirstLast("   ", "   ", "Spaces_Only");

        // Unicode / special characters
        TestSwapFirstLast("🙂middle😎", "😎middle🙂", "Emoji_Swap");
        TestSwapFirstLast("あい", "いあ", "Japanese_Chars");
        // TestSwapFirstLast("👍🏽👎🏼", "👎🏼👍🏽", "MultiEmoji");
    }

    static void TestSwapFirstLast(string input, string expected, string testName)
    {
        try
        {
            string actual = SwapFirstLastChar(input);

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

    static string SwapFirstLastChar(string input)
    {
        StringInfo stringInfo = new StringInfo(input);
        int length = stringInfo.LengthInTextElements;

        if (length <= 1) return input;

        string first = stringInfo.SubstringByTextElements(0, 1);
        string last = stringInfo.SubstringByTextElements(length - 1, 1);

        string middle = "";

        for (int i = 1; i < length - 1; i++)
        {
            middle += stringInfo.SubstringByTextElements(i, 1);
        }
        return last + middle + first;
    }
}
