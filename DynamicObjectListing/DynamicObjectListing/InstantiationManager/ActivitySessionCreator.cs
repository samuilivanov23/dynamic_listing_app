using DynamicObjectListing.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicObjectListing.InstantiationManager
{
    public class ActivitySessionCreator : ICreator<ActivitySession>
    {
        public ActivitySessionCreator() { }
        public bool CanHandle(string type) { return "ActivitySession" == type; }
        public ActivitySession Create() { return new ActivitySession(); }
    }
}
