using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivityHopperCsharp
{
    internal class Activity
    {
        private string name;
        private bool hasBeenSuggested = false;
        public Activity(string name)
        {
            this.name = name;
        }

        public string Name { get; }
    }
}
