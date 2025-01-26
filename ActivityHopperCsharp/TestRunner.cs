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

            // AssertEquals("Test activity", testActivity.GetName(), "Test getting activity name via GetName()");

            Console.WriteLine("All tests complete.");
        }

        public void AssertEquals(string expected, string actual, string testName)
        {
            if (expected == actual)
            {
                Console.WriteLine($"[Success] {testName}");
            }
            else
            {
                Console.WriteLine($"[Fail] {testName} - Expected: {expected}, Actual: {actual}");
            }
        }
    }
}
