using System;

class Within20Test
{
    static void Main(string[] args)
    {
        RunTests();
    }

    static void RunTests()
    {
        // ✅ Within 20 of 100
        TestIsWithin20(100, true, "Exactly_100");
        TestIsWithin20(120, true, "Exactly_120");
        TestIsWithin20(80, true, "Exactly_80");
        TestIsWithin20(105, true, "MidRange_100");
        TestIsWithin20(99, true, "Just_Below_100");

        // ✅ Within 20 of 200
        TestIsWithin20(200, true, "Exactly_200");
        TestIsWithin20(180, true, "Exactly_180");
        TestIsWithin20(220, true, "Exactly_220");
        TestIsWithin20(199, true, "Just_Below_200");

        // ❌ Outside both ranges
        TestIsWithin20(50, false, "Too_Low");
        TestIsWithin20(250, false, "Too_High");
        TestIsWithin20(121, false, "Just_Over_120");
        TestIsWithin20(179, false, "Just_Under_180");

        // ✅ Edge values
        TestIsWithin20(101, true, "Slightly_Over_100");
        TestIsWithin20(201, true, "Slightly_Over_200");
        TestIsWithin20(79, false, "One_Below_80");
        TestIsWithin20(221, false, "One_Above_220");
    }

    static void TestIsWithin20(int n, bool expected, string testName)
    {
        try
        {
            bool actual = IsWithin20Of100Or200(n); // You will implement this

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
    static bool IsWithin20Of100Or200(int n)
    {
        return (n >= (100 - 20) && n <= (100 + 20))  || (n >= (200 - 20) && n <= (200 + 20));
    }
}
