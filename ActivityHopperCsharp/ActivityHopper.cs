using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivityHopperCsharp
{
    internal class ActivityHopper
    {
        List<Activity> activities;
        public ActivityHopper()
        {
            activities = InitializeActivities();
        }

        private List<Activity> InitializeActivities()
        {
            List<Activity> newActivityList = new List<Activity>();
            newActivityList.Add(new Activity("Go for a walk"));
            newActivityList.Add(new Activity("Do the dishes"));
            newActivityList.Add(new Activity("Read a book"));
            newActivityList.Add(new Activity("Do a CodeWars kata"));
            return newActivityList;
        }

        public int Count()
        {
            return activities.Count;
        }

        public Activity GetFirstActivity()
        {
            return activities.First();
        }
    }
}
