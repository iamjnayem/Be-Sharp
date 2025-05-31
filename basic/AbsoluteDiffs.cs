using System;

class AbsoluteDiffs
{
    static void Main(string[] args)
    {
        RunTests();
    }

    static void RunTests()
    {
        // ✅ Different values, a > b
        TestAbsoluteDiff(10, 5, 10, "A_Greater_B_Positive");
        TestAbsoluteDiff(-2, -5, 6, "A_Greater_B_Negative");

        // ✅ Different values, a < b
        TestAbsoluteDiff(5, 10, 5, "A_Less_B_Positive");
        TestAbsoluteDiff(-5, -2, 3, "A_Less_B_Negative");

        // ✅ Same values
        TestAbsoluteDiff(0, 0, 0, "Zero_Zero");
        TestAbsoluteDiff(5, 5, 0, "Same_Positive");
        TestAbsoluteDiff(-5, -5, 0, "Same_Negative");

        // ✅ One zero
        TestAbsoluteDiff(0, 7, 7, "Zero_Seven");
        TestAbsoluteDiff(7, 0, 14, "Seven_Zero");

        // ✅ Mixed signs
        TestAbsoluteDiff(-5, 5, 10, "Neg_Pos");
        TestAbsoluteDiff(5, -5, 20, "Pos_Neg");

        // ✅ Edge values
        TestAbsoluteDiff(int.MaxValue, int.MinValue, (long)(int.MaxValue - (long)int.MinValue) * 2, "Max_Min");
        TestAbsoluteDiff(int.MinValue, int.MaxValue, (long)(int.MaxValue - (long)int.MinValue), "Min_Max");
    }

    static void TestAbsoluteDiff(int a, int b, long expected, string testName)
    {
        try
        {
            long actual = AbsoluteDiff(a, b); // You will implement this

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
    static long AbsoluteDiff(int a, int b)
    {
        long result;

        if (a > b)
        {
            result = 2 * Math.Abs(a - b);
        }
        retuls = Math.Abs(a - b);

        // long diff = Math.Abs((long)a - b); // Cast to long before subtraction
        // return a > b ? 2 * diff : diff;
    }
}
