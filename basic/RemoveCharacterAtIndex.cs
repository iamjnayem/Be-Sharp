using System;

class RemoveCharAtIndex
{
    static void Main(string[] args)
    {
        RunTests();
    }

    static void RunTests()
    {
        // Basic test cases from the sample
        TestRemoveCharAtIndex("w3resource", 1, "wresource", "Sample_1");
        TestRemoveCharAtIndex("w3resource", 9, "w3resourc", "Sample_2");
        TestRemoveCharAtIndex("w3resource", 0, "3resource", "Sample_3");

        // Edge cases
        TestRemoveCharAtIndex("a", 0, "", "SingleChar_Remove");
        TestRemoveCharAtIndex("hello", 4, "hell", "Remove_Last");
        TestRemoveCharAtIndex("hello", 2, "helo", "Remove_Mid");
        TestRemoveCharAtIndex("world", 0, "orld", "Remove_First");

        // More tests
        TestRemoveCharAtIndex("OpenAI", 3, "OpeAI", "Remove_At_3");
        TestRemoveCharAtIndex("ChatGPT", 6, "ChatGP", "Remove_Last_Char");

        // Boundary & invalid input tests
        TestRemoveCharAtIndex("test", -1, null, "Invalid_Negative_Index");
        TestRemoveCharAtIndex("test", 4, null, "Invalid_Index_Equal_Length");
        TestRemoveCharAtIndex("test", 10, null, "Invalid_Index_Too_High");
        TestRemoveCharAtIndex("", 0, null, "Invalid_Empty_String");
    }

    static void TestRemoveCharAtIndex(string input, int index, string expected, string testName)
    {
        try
        {
            string actual = RemoveCharAt(input, index);

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
            if (expected == null)
            {
                Console.WriteLine($"{testName} ✅ PASSED (Expected Exception: {ex.Message})");
            }
            else
            {
                Console.WriteLine($"{testName} ❌ FAILED with Exception: {ex.Message}");
            }
        }
    }

    static string RemoveCharAt(string input, int index)
    {
        string result = input.Remove(index, 1);
        return result;
    }
}
