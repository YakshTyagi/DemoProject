using System;
using System.Collections.Generic;

namespace Backstage.Models
{
    public partial class SubscriptionPolicies
    {
        public SubscriptionPolicies()
        {
            Asset = new HashSet<Asset>();
            SubPolicyContentCrossref = new HashSet<SubPolicyContentCrossref>();
            SubsriptionTerms = new HashSet<SubsriptionTerms>();
        }

        public int Id { get; set; }
        public string ContractName { get; set; }
        public int PolicyId { get; set; }
        public string PolicyType { get; set; }
        public int Duration { get; set; }
        public bool IsFree { get; set; }
        public bool? IsEncrypted { get; set; }

        public virtual ICollection<Asset> Asset { get; set; }
        public virtual ICollection<SubPolicyContentCrossref> SubPolicyContentCrossref { get; set; }
        public virtual ICollection<SubsriptionTerms> SubsriptionTerms { get; set; }
    }
}
