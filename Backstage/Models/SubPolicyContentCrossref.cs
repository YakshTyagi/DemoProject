using System;
using System.Collections.Generic;

namespace Backstage.Models
{
    public partial class SubPolicyContentCrossref
    {
        public long Id { get; set; }
        public int PolicyId { get; set; }
        public int ContentId { get; set; }

        public virtual MetadataContentTypes Content { get; set; }
        public virtual SubscriptionPolicies Policy { get; set; }
    }
}
