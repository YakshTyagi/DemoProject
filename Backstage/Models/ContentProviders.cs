using System;
using System.Collections.Generic;

namespace Backstage.Models
{
    public partial class ContentProviders
    {
        public ContentProviders()
        {
            AssetOffers = new HashSet<AssetOffers>();
        }

        public int ProviderId { get; set; }
        public int BillingId { get; set; }
        public string ProviderName { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime LicenseStart { get; set; }
        public DateTime LicenseEnd { get; set; }
        public string Provider { get; set; }
        public int SuggestedPrice { get; set; }
        public TimeSpan MaximumViewingLength { get; set; }
        public bool SmilSpecialProfile { get; set; }

        public virtual ICollection<AssetOffers> AssetOffers { get; set; }
    }
}
