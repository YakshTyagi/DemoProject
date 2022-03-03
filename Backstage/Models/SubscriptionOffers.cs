using System;
using System.Collections.Generic;

namespace Backstage.Models
{
    public partial class SubscriptionOffers
    {
        public int OfferId { get; set; }
        public int SubId { get; set; }
        public int MajorVersion { get; set; }
        public int MinorVersion { get; set; }
        public DateTime CreationDateTime { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public string BillingId { get; set; }
        public string ProviderContentTier { get; set; }

        public virtual SubscriptionPackages Sub { get; set; }
    }
}
