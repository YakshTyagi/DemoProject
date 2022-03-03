using System;
using System.Collections.Generic;

namespace Backstage.Models
{
    public partial class SubscriptionPackages
    {
        public SubscriptionPackages()
        {
            ServiceSubscriptionPackages = new HashSet<ServiceSubscriptionPackages>();
            SubscriptionDescriptions = new HashSet<SubscriptionDescriptions>();
            SubscriptionDetails = new HashSet<SubscriptionDetails>();
            SubscriptionLanguages = new HashSet<SubscriptionLanguages>();
            SubscriptionOffers = new HashSet<SubscriptionOffers>();
            SubsriptionTerms = new HashSet<SubsriptionTerms>();
        }

        public int SubId { get; set; }
        public int SmspackageId { get; set; }
        public string Name { get; set; }
        public bool Alacarte { get; set; }
        public bool IsEnabled { get; set; }

        public virtual ICollection<ServiceSubscriptionPackages> ServiceSubscriptionPackages { get; set; }
        public virtual ICollection<SubscriptionDescriptions> SubscriptionDescriptions { get; set; }
        public virtual ICollection<SubscriptionDetails> SubscriptionDetails { get; set; }
        public virtual ICollection<SubscriptionLanguages> SubscriptionLanguages { get; set; }
        public virtual ICollection<SubscriptionOffers> SubscriptionOffers { get; set; }
        public virtual ICollection<SubsriptionTerms> SubsriptionTerms { get; set; }
    }
}
