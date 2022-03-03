using System;
using System.Collections.Generic;

namespace Backstage.Models
{
    public partial class ServiceSubscriptionPackages
    {
        public long Id { get; set; }
        public int ServiceId { get; set; }
        public int SubId { get; set; }
        public bool IsDisplayed { get; set; }

        public virtual Services Service { get; set; }
        public virtual SubscriptionPackages Sub { get; set; }
    }
}
