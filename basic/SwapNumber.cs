using System;

class SwapNumber
{
    static void Main(string[] args)
    {
        RunTests();
    }

    static void RunTests()
    {
        TestSwap_PositiveNumbers();
        TestSwap_NegativeNumbers();
        TestSwap_ZeroAndPositive();
        TestSwap_SameNumbers();
    }

    static void TestSwap_PositiveNumbers()
    {
        int a = 5, b = 6;
        SwapNumbers(ref a, ref b);
        AssertEqual(a, 6, b, 5, "TestSwap_PositiveNumbers");
    }

    static void TestSwap_NegativeNumbers()
    {
        int a = -10, b = -20;
        SwapNumbers(ref a, ref b);
        AssertEqual(a, -20, b, -10, "TestSwap_NegativeNumbers");
    }

    static void TestSwap_ZeroAndPositive()
    {
        int a = 0, b = 100;
        SwapNumbers(ref a, ref b);
        AssertEqual(a, 100, b, 0, "TestSwap_ZeroAndPositive");
    }

    static void TestSwap_SameNumbers()
    {
        int a = 42, b = 42;
        SwapNumbers(ref a, ref b);
        AssertEqual(a, 42, b, 42, "TestSwap_SameNumbers");
    }

    static void AssertEqual(int actualA, int expectedA, int actualB, int expectedB, string testName)
    {
        if (actualA == expectedA && actualB == expectedB)
            Console.WriteLine($"{testName} ✅ PASSED");
        else
            Console.WriteLine($"{testName} ❌ FAILED\nExpected A: {expectedA}, Got A: {actualA}\nExpected B: {expectedB}, Got B: {actualB}");
    }

    static void SwapNumbers(ref int a, ref int b)
    {
        int c = a;
        a = b;
        b = c;
    }
}
