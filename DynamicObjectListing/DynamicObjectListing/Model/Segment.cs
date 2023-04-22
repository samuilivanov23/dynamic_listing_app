using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicObjectListing.Model
{
    [Table("segments")]
    public class Segment
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity), Key()]
        public Int64 Id { get; set; }
        public double Length { get; set; }
        public int BestEffortTimeMinutes { get; set; }
        public string StartLocation { get; set; }
        public string EndLocation { get; set; }
        public override string ToString()
        {
            return Length + BestEffortTimeMinutes+ ", Start Location: " + StartLocation + ", End Location: " + EndLocation;
        }
    }
}