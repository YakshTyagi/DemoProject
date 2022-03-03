using System;
using System.Collections.Generic;

namespace Backstage.Models
{
    public partial class ShowTypes
    {
        public ShowTypes()
        {
            AssetTitleDetails = new HashSet<AssetTitleDetails>();
            EpgSettings = new HashSet<EpgSettings>();
            ServiceAddtionalDetails = new HashSet<ServiceAddtionalDetails>();
            SubscriptionDetails = new HashSet<SubscriptionDetails>();
        }

        public int ShowId { get; set; }
        public string ShowType { get; set; }

        public virtual ICollection<AssetTitleDetails> AssetTitleDetails { get; set; }
        public virtual ICollection<EpgSettings> EpgSettings { get; set; }
        public virtual ICollection<ServiceAddtionalDetails> ServiceAddtionalDetails { get; set; }
        public virtual ICollection<SubscriptionDetails> SubscriptionDetails { get; set; }
    }
}
