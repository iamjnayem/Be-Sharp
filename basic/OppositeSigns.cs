using System;

class OppositeSigns
{
    static void Main(string[] args)
    {
        RunTests();
    }

    static void RunTests()
    {
        // ✅ Typical valid cases
        TestCheckOppositeSigns(-5, 25, true, "Neg_Pos");
        TestCheckOppositeSigns(5, -25, true, "Pos_Neg");

        // ✅ Both positive
        TestCheckOppositeSigns(5, 100, false, "Both_Positive");

        // ✅ Both negative
        TestCheckOppositeSigns(-5, -100, false, "Both_Negative");

        // ✅ One zero
        TestCheckOppositeSigns(0, 5, false, "Zero_Positive");
        TestCheckOppositeSigns(-5, 0, false, "Negative_Zero");
        TestCheckOppositeSigns(0, -5, false, "Zero_Negative");
        TestCheckOppositeSigns(0, 0, false, "Zero_Zero");

        // ✅ Large numbers
        TestCheckOppositeSigns(int.MaxValue, int.MinValue, true, "Max_Min");
        TestCheckOppositeSigns(int.MinValue, int.MaxValue, true, "Min_Max");

        // ✅ Edge values
        TestCheckOppositeSigns(int.MaxValue, 1, false, "Max_Positive");
        TestCheckOppositeSigns(int.MinValue, -1, false, "Min_Negative");

        // ✅ Negatives with same value
        TestCheckOppositeSigns(-1, -1, false, "Same_Negatives");

        // ✅ Positives with same value
        TestCheckOppositeSigns(999, 999, false, "Same_Positives");

        // ✅ One positive, one negative, same absolute
        TestCheckOppositeSigns(-10, 10, true, "NegPos_SameAbs");
        TestCheckOppositeSigns(10, -10, true, "PosNeg_SameAbs");

        // ✅ Random opposite sign combinations
        TestCheckOppositeSigns(-999999, 1, true, "BigNeg_SmallPos");
        TestCheckOppositeSigns(1, -999999, true, "SmallPos_BigNeg");
    }

    static void TestCheckOppositeSigns(int a, int b, bool expected, string testName)
    {
        try
        {
            bool actual = CheckOppositeSigns(a, b); // Assume your implementation exists

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

    static bool CheckOppositeSigns(int a, int b)
    {
        if (a == 0 || b == 0) return false;
        return (a ^ b) < 0;
    }
}
