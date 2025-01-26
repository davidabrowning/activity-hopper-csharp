using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivityHopperCsharp
{
    internal class TestRunner
    {
        // Constructor
        public TestRunner()
        {

        }

        public void RunAllTests()
        {
            Console.WriteLine("Running tests...");

            // General test prep
            Activity testActivity = new Activity("Test activity");

            AssertEquals("Test activity", testActivity.Name, "Test getting activity name via Name");

            AssertFalse(testActivity.HasBeenSuggested, "HasBeenSuggested is initially false");

            Activity suggestedActivity = new Activity("Suggested activity");
            suggestedActivity.HasBeenSuggested = true;
            AssertTrue(suggestedActivity.HasBeenSuggested, "Suggested Activity has HasBeenSuggested == true");

            Console.WriteLine("All tests complete.");
        }

        public void PrintSuccess(string testMessage)
        {
            Console.WriteLine($"[Success] {testMessage}");
        }

        public void PrintFailure(string testMessage)
        {
            Console.WriteLine($"[Failure] {testMessage}");
        }

        public void AssertEquals(string expected, string actual, string testName)
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

        public void AssertFalse(bool testResult, string testName)
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

        public void AssertTrue(bool testResult, string testName)
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
