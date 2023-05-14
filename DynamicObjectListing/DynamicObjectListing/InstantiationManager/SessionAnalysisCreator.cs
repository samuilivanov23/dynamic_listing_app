using DynamicObjectListing.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicObjectListing.InstantiationManager
{
    public class SessionAnalysisCreator : ICreator<SessionAnalysis>
    {
        public SessionAnalysisCreator() { }
        public bool CanHandle(string type) { return "SessionAnalysis" == type; }
        public SessionAnalysis Create() { return new SessionAnalysis(); }
    }
}
