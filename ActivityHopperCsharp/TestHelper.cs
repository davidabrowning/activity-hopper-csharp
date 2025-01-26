using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivityHopperCsharp
{
    internal class TestHelper
    {
        public static void PrintSuccess(string testMessage)
        {
            Console.WriteLine($"[Success] {testMessage}");
        }

        public static void PrintFailure(string testMessage)
        {
            Console.WriteLine($"[Failure] {testMessage}");
        }

        public static void AssertEquals(string expected, string actual, string testName)
        {
            if (expected == actual)
            {
                PrintSuccess(testName);
            }
            else
            {
                PrintFailure($"{testName} - Expected: {expected}, Actual: {actual}");
            }
        }

        public static void AssertNotEquals(string a, string b, string testName)
        {
            if (a != b)
            {
                PrintSuccess(testName);
            }
            else
            {
                PrintFailure($"{testName} - The values are unexpectedly equal: {a} and {b}");
            }
        }

        public static void AssertFalse(bool testResult, string testName)
        {
            if (testResult == false)
            {
                PrintSuccess(testName);
            }
            else
            {
                PrintFailure($"{testName} - Expected: false, Actual: {testResult}");
            }

        }

        public static void AssertTrue(bool testResult, string testName)
        {
            if (testResult)
            {
                PrintSuccess(testName);
            }
            else
            {
                PrintFailure($"{testName} - Expected: false, Actual: {testResult}");
            }
        }
    }
}
