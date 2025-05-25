using System;
using System.IO;

class CelsiusConverterTest
{
    static void Main(string[] args)
    {
        RunTests();
    }

    static void RunTests()
    {
        TestCelsiusConversions(30, 303, 86, "Test_30C");
        TestCelsiusConversions(0, 273, 32, "Test_0C");
        TestCelsiusConversions(100, 373, 212, "Test_100C");
        TestCelsiusConversions(-40, 233, -40, "Test_Minus40C");
    }

    static void TestCelsiusConversions(int celsius, int expectedKelvin, int expectedFahrenheit, string testName)
    {
        int actualKelvin = CelsiusToKelvin(celsius);
        int actualFahrenheit = CelsiusToFahrenheit(celsius);

        bool kelvinOk = actualKelvin == expectedKelvin;
        bool fahrenheitOk = actualFahrenheit == expectedFahrenheit;

        if (kelvinOk && fahrenheitOk)
        {
            Console.WriteLine($"{testName} ✅ PASSED");
        }
        else
        {
            Console.WriteLine($"{testName} ❌ FAILED");
            if (!kelvinOk)
                Console.WriteLine($"  Kelvin - Expected: {expectedKelvin}, Got: {actualKelvin}");
            if (!fahrenheitOk)
                Console.WriteLine($"  Fahrenheit - Expected: {expectedFahrenheit}, Got: {actualFahrenheit}");
        }
    }

    static int CelsiusToKelvin(int celsius)
    {
        return celsius + 273;
    }

    static int CelsiusToFahrenheit(int celsius)
    {

        return (int)(celsius * 1.8 + 32);
    }
}
