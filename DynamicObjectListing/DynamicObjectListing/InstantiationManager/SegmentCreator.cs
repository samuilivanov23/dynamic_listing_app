using DynamicObjectListing.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicObjectListing.InstantiationManager
{
    public class SegmentCreator : ICreator<Segment>
    {
        public SegmentCreator() { }
        public bool CanHandle(string type) { return "segments" == type; }
        public Segment Create() { return new Segment(); }
    }
}
