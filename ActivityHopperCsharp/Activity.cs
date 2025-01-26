using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivityHopperCsharp
{
    internal class Activity
    {
        private bool hasBeenSuggested = false;
        public Activity(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}
