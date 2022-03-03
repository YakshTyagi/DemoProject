using System;
using System.Collections.Generic;

namespace Backstage.Models
{
    public partial class Services
    {
        public Services()
        {
            EpgEvents = new HashSet<EpgEvents>();
            EpgScheduleFiles = new HashSet<EpgScheduleFiles>();
            ServiceAddtionalDetails = new HashSet<ServiceAddtionalDetails>();
            ServiceConfigurations = new HashSet<ServiceConfigurations>();
            ServiceDescriptions = new HashSet<ServiceDescriptions>();
            ServiceDisplayedSubscriptionPackages = new HashSet<ServiceDisplayedSubscriptionPackages>();
            ServiceEncryptionProfiles = new HashSet<ServiceEncryptionProfiles>();
            ServiceEpgConfigurations = new HashSet<ServiceEpgConfigurations>();
            ServiceGenres = new HashSet<ServiceGenres>();
            ServiceLanguages = new HashSet<ServiceLanguages>();
            ServiceLogos = new HashSet<ServiceLogos>();
            ServiceSubscriptionPackages = new HashSet<ServiceSubscriptionPackages>();
        }

        public int ServiceId { get; set; }
        public string ServiceName { get; set; }
        public int? LinearServiceId { get; set; }
        public int? CatchupServiceId { get; set; }
        public int? LcnNumber { get; set; }

        public virtual ICollection<EpgEvents> EpgEvents { get; set; }
        public virtual ICollection<EpgScheduleFiles> EpgScheduleFiles { get; set; }
        public virtual ICollection<ServiceAddtionalDetails> ServiceAddtionalDetails { get; set; }
        public virtual ICollection<ServiceConfigurations> ServiceConfigurations { get; set; }
        public virtual ICollection<ServiceDescriptions> ServiceDescriptions { get; set; }
        public virtual ICollection<ServiceDisplayedSubscriptionPackages> ServiceDisplayedSubscriptionPackages { get; set; }
        public virtual ICollection<ServiceEncryptionProfiles> ServiceEncryptionProfiles { get; set; }
        public virtual ICollection<ServiceEpgConfigurations> ServiceEpgConfigurations { get; set; }
        public virtual ICollection<ServiceGenres> ServiceGenres { get; set; }
        public virtual ICollection<ServiceLanguages> ServiceLanguages { get; set; }
        public virtual ICollection<ServiceLogos> ServiceLogos { get; set; }
        public virtual ICollection<ServiceSubscriptionPackages> ServiceSubscriptionPackages { get; set; }
    }
}
