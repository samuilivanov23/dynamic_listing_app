using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DynamicObjectListing.Model
{
    [Table( "athletes" )]
    public class Athlete : AbstractEntity
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity), Key()]
        public Int64 Id { get; set; }
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public int ActivitiesCount { get; set; }

        public int Followers { get; set; }

        public int Following { get; set; }
        public override string ToString()
        {
            return FirstName + LastName + ", Activities Count: " + ActivitiesCount + ", Followers: " + Followers + ", Following: " + Following;
        }
    }
}
