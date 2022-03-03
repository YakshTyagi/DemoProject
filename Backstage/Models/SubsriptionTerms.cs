using System;
using System.Collections.Generic;

namespace Backstage.Models
{
    public partial class SubsriptionTerms
    {
        public int TermId { get; set; }
        public int SubId { get; set; }
        public int PolicyId { get; set; }
        public int SuggestedPrice { get; set; }

        public virtual SubscriptionPolicies Policy { get; set; }
        public virtual SubscriptionPackages Sub { get; set; }
    }
}
