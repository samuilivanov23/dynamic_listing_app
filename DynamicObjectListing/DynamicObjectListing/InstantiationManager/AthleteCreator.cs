using DynamicObjectListing.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicObjectListing.InstantiationManager
{
    public class AthleteCreator : ICreator<Athlete>
    {
        public AthleteCreator() { }
        public bool CanHandle(string type) { return "Athlete" == type; }
        public Athlete Create() { return new Athlete(); }
    }
}