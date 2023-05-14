using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicObjectListing.Model
{
    internal class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("Data Source=DESKTOP-BUOKINV;Initial Catalog=ps_object_listing;Integrated Security=True") { }

        public DbSet<Athlete> Athletes { get; set; }
        public DbSet<ActivitySession> ActivitySessions { get; set; }
        public DbSet<Segment> Segments { get; set; }
        public DbSet<SessionAnalysis> SessionAnalyses { get; set; }
    }
}
