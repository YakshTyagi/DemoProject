using System;
using System.Collections.Generic;

namespace Backstage.Models
{
    public partial class AssetOffers
    {
        public long Id { get; set; }
        public long AssetId { get; set; }
        public string BillingId { get; set; }
        public string ProviderContentTier { get; set; }
        public int SuggestedPrice { get; set; }
        public int ProviderId { get; set; }

        public virtual Asset Asset { get; set; }
        public virtual ContentProviders Provider { get; set; }
    }
}
