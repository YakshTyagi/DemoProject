using System;
using System.Collections.Generic;

namespace Backstage.Models
{
    public partial class EpgEvents
    {
        public EpgEvents()
        {
            EpgAudioLanguages = new HashSet<EpgAudioLanguages>();
            EpgCaEntitlements = new HashSet<EpgCaEntitlements>();
            EpgCasting = new HashSet<EpgCasting>();
            EpgDescriptions = new HashSet<EpgDescriptions>();
            EpgEventIdentifiers = new HashSet<EpgEventIdentifiers>();
            EpgGroupRecord = new HashSet<EpgGroupRecord>();
            EpgSettings = new HashSet<EpgSettings>();
            EpgTags = new HashSet<EpgTags>();
            EpgXtiEventCrossref = new HashSet<EpgXtiEventCrossref>();
        }

        public long EventId { get; set; }
        public int ServiceId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public long FileId { get; set; }

        public virtual EpgScheduleFiles File { get; set; }
        public virtual Services Service { get; set; }
        public virtual ICollection<EpgAudioLanguages> EpgAudioLanguages { get; set; }
        public virtual ICollection<EpgCaEntitlements> EpgCaEntitlements { get; set; }
        public virtual ICollection<EpgCasting> EpgCasting { get; set; }
        public virtual ICollection<EpgDescriptions> EpgDescriptions { get; set; }
        public virtual ICollection<EpgEventIdentifiers> EpgEventIdentifiers { get; set; }
        public virtual ICollection<EpgGroupRecord> EpgGroupRecord { get; set; }
        public virtual ICollection<EpgSettings> EpgSettings { get; set; }
        public virtual ICollection<EpgTags> EpgTags { get; set; }
        public virtual ICollection<EpgXtiEventCrossref> EpgXtiEventCrossref { get; set; }
    }
}
