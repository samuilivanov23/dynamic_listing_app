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
    public class Athlete : IBaseModel
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity), Key()]
        public Int64 Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int ActivitiesCount { get; set; }
        public int Followers { get; set; }
        public int Following { get; set; }

        public Athlete() { }

        public Athlete(Int64 id, string firstName, string middleName, string lastName, int activitiesCount, int followers, int following)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.ActivitiesCount = activitiesCount;
            this.Followers = followers;
            this.Following = following;
        }

        public override string ToString()
        {
            return FirstName + LastName + ", Activities Count: " + ActivitiesCount + ", Followers: " + Followers + ", Following: " + Following;
        }
    }
}
