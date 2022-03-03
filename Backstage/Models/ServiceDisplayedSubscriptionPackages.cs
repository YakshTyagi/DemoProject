using System;
using System.Collections.Generic;

namespace Backstage.Models
{
    public partial class ServiceDisplayedSubscriptionPackages
    {
        public long Id { get; set; }
        public int ServiceId { get; set; }
        public string DisplayedSubscriptionPackage { get; set; }

        public virtual Services Service { get; set; }
    }
}
