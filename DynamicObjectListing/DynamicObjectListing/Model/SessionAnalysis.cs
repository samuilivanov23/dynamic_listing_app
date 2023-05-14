using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicObjectListing.Model
{
    [Table("session_analysis")]
    public class SessionAnalysis : IBaseModel
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity), Key()]
        public Int64 Id { get; set; }
        public int HeartRateMin { get; set; }
        public int HeartRateMax { get; set; }
        public int HeartRateAvg { get; set; }
        public int PowerAvg { get; set; }
        public SessionAnalysis() { }

        public SessionAnalysis(Int64 id, int heartRateMin, int hearthRateMax, int hearthRateAvg, int powerAvg)
        {
            this.Id = id;
            this.HeartRateMin = heartRateMin;
            this.HeartRateMax = hearthRateMax;
            this.HeartRateAvg = hearthRateAvg;
            this.PowerAvg = powerAvg;
        }
    }
}
