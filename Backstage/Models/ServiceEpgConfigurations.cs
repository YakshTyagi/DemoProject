using System;
using System.Collections.Generic;

namespace Backstage.Models
{
    public partial class ServiceEpgConfigurations
    {
        public int Id { get; set; }
        public int ServiceId { get; set; }
        public string EpgCode { get; set; }
        public bool Catchup { get; set; }
        public bool Downloadable { get; set; }
        public bool Stbenabled { get; set; }
        public int Expiryperiod { get; set; }
        public int Downloadexpiryperiod { get; set; }
        public bool IsShowcaseService { get; set; }
        public string VoiceKeywords { get; set; }
        public string DvbTriplet { get; set; }

        public virtual Services Service { get; set; }
    }
}
