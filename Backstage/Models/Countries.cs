using System;
using System.Collections.Generic;

namespace Backstage.Models
{
    public partial class Countries
    {
        public Countries()
        {
            AssetTitleDetails = new HashSet<AssetTitleDetails>();
            ServiceAddtionalDetails = new HashSet<ServiceAddtionalDetails>();
            SubscriptionDetails = new HashSet<SubscriptionDetails>();
        }

        public int CountryId { get; set; }
        public string CountryName { get; set; }

        public virtual ICollection<AssetTitleDetails> AssetTitleDetails { get; set; }
        public virtual ICollection<ServiceAddtionalDetails> ServiceAddtionalDetails { get; set; }
        public virtual ICollection<SubscriptionDetails> SubscriptionDetails { get; set; }
    }
}
