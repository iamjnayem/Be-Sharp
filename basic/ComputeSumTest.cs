using System;

class ComputeSumTest
{
    static void Main(string[] args)
    {
        RunTests();
    }

    static void RunTests()
    {
        // ✅ Different values
        TestComputeSum(5, 10, 15, "Diff_Positive");
        TestComputeSum(-5, 10, 5, "Neg_Positive");
        TestComputeSum(5, -10, -5, "Pos_Negative");
        TestComputeSum(-5, -10, -15, "Both_Negative");

        // ✅ Same values (tripled)
        TestComputeSum(5, 5, 30, "Same_Positive");
        TestComputeSum(-5, -5, -30, "Same_Negative");
        TestComputeSum(0, 0, 0, "Same_Zero");

        // ✅ Edge values
        // TestComputeSum(int.MaxValue, int.MaxValue, int.MaxValue * 3 * 2, "Max_Max_Tripled");
        // TestComputeSum(int.MinValue, int.MinValue, int.MinValue * 3 * 2, "Min_Min_Tripled");
        // TestComputeSum(int.MaxValue, int.MinValue, -1, "Max_Min");

        // ✅ One zero
        TestComputeSum(0, 5, 5, "Zero_Positive");
        TestComputeSum(-5, 0, -5, "Negative_Zero");

        // ✅ Same large number
        TestComputeSum(999999, 999999, 999999 * 6, "Same_Large_Positive");
    }

    static void TestComputeSum(int a, int b, long expected, string testName)
    {
        try
        {
            long actual = ComputeSum(a, b); // You will implement this

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

    // 🔧 Your implementation goes here
    static long ComputeSum(int a, int b)
    {
        return a == b ? (long)(a + b) * 3 : (long)a + b;
    }
}
