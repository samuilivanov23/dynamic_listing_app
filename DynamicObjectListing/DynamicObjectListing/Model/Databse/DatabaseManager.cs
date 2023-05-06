using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicObjectListing.Model.Databse
{
    public class DatabaseManager
    {
        DatabaseContext DbContext;

        public DatabaseManager() 
        {
            DbContext = new DatabaseContext();
        }

        public List<Athlete> GetAthletes() 
        {
            return DbContext.Athletes.ToList();
        }
        public List<ActivitySession> GetActivitySessions()
        {
            return DbContext.ActivitySessions.ToList();
        }
        public List<Segment> GetSegments()
        {
            return DbContext.Segments.ToList();
        }
    }
}
