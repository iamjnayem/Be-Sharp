using System;

class IsTwentyCheckTest
{
    static void Main(string[] args)
    {
        RunTests();
    }

    static void RunTests()
    {
        // ✅ One value is 20
        TestIsTwentyCheck(20, 5, true, "A_Is_20");
        TestIsTwentyCheck(3, 20, true, "B_Is_20");

        // ✅ Sum is 20
        TestIsTwentyCheck(15, 5, true, "Sum_Is_20");
        TestIsTwentyCheck(10, 10, true, "Equal_Sum_20");
        TestIsTwentyCheck(-10, 30, true, "Neg_Pos_Sum_20");

        // ❌ None is 20 and sum isn't 20
        TestIsTwentyCheck(5, 7, false, "Random_No_20");
        TestIsTwentyCheck(0, 0, false, "Zero_Zero");
        TestIsTwentyCheck(19, 0, false, "Almost_20");
        TestIsTwentyCheck(21, -1, true, "Sum_Not_20");

        // ✅ Edge cases
        TestIsTwentyCheck(int.MaxValue, -int.MaxValue + 20, true, "Edge_Sum_20");
        TestIsTwentyCheck(int.MinValue, 20, true, "Min_And_20");
    }

    static void TestIsTwentyCheck(int a, int b, bool expected, string testName)
    {
        try
        {
            bool actual = IsTwentyCheck(a, b); // You will implement this

            if (actual == expected)
            {
                Console.WriteLine($"{testName} ✅ PASSED");
            }
            else
            {
                Console.WriteLine($"{testName} ❌ FAILED");
                Console.WriteLine($"  Expected: {expected}, Got: {actual}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"{testName} ❌ FAILED with Exception: {ex.Message}");
        }
    }

    // 🔧 Your implementation will go here
    static bool IsTwentyCheck(int a, int b)
    {
        return a == 20 || b == 20 || (a + b) == 20;
    }
}
