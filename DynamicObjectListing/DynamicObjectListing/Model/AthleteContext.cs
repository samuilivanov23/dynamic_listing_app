using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DynamicObjectListing.Model
{
    internal class AthleteContext : DbContext
    {
        public AthleteContext() : base("Data Source=DESKTOP-BUOKINV;Initial Catalog=ps_object_listing;Integrated Security=True") { }
        public DbSet<Athlete> Athletes { get; set; }
    }
}
