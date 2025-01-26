using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivityHopperCsharp
{
    internal class Activity
    {
        public Activity(string name)
        {
            Name = name;
            HasBeenSuggested = false;
        }

        public string Name { get; }
        public bool HasBeenSuggested { get; set; }
    }
}
