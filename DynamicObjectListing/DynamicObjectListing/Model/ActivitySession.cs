using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicObjectListing.Model
{
    [Table("activity_sessions")]
    public class ActivitySession : IBaseModel
    {

        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity), Key()]
        public Int64 Id { get; set; }
        public double Distance { get; set; }
        public int ElevationGain { get; set; }
        public int MaxElevation { get; set; }
        public int TimeMovingMinutes { get; set; }
        public int TotalTimeMinutes { get; set; }
        public int KudosCount { get; set; }

        public ActivitySession() { }

        public ActivitySession(Int64 id, double distance, int elevationGain, int maxElevation, int timeMovingMinutes, int totalTimeMinutes, int kudosCount)
        {
            this.Id = id;
            this.Distance = distance;
            this.ElevationGain = elevationGain;
            this.MaxElevation = maxElevation;
            this.TimeMovingMinutes = timeMovingMinutes;
            this.TotalTimeMinutes = totalTimeMinutes;
            this.KudosCount = kudosCount;
        }

        public override string ToString()
        {
            return Distance + ElevationGain+ ", Max Elevation: " + MaxElevation + ", Time Moving: " + TimeMovingMinutes + ", Total Time: " + TotalTimeMinutes + "Kudos Count: " + KudosCount;
        }
    }
}
