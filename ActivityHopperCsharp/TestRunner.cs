using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivityHopperCsharp
{
    internal class TestRunner
    {
        public void RunAllTests()
        {
            Console.WriteLine("Running tests...");

            // General test prep
            Activity testActivity = new Activity("Test activity");
            ActivityHopper testActivityHopper = new ActivityHopper();

            TestHelper.AssertEquals("Test activity", testActivity.Name, "Test getting activity name via Name");

            TestHelper.AssertFalse(testActivity.HasBeenSuggested, "HasBeenSuggested is initially false");

            Activity suggestedActivity = new Activity("Suggested activity");
            suggestedActivity.HasBeenSuggested = true;
            TestHelper.AssertTrue(suggestedActivity.HasBeenSuggested, "Suggested Activity has HasBeenSuggested == true");

            TestHelper.AssertTrue(testActivityHopper.Count() > 0, "New ActivityHopper has Count > 0");

            Activity a1 = testActivityHopper.GetFirstActivity();
            Activity a2 = testActivityHopper.GetFirstActivity();
            TestHelper.AssertNotEquals(a1.Name, a2.Name, "Two drawn Activities are not equal");

            Console.WriteLine("All tests complete.");
        }
    }
}
