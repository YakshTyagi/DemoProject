using System;
using System.Collections.Generic;

namespace Backstage.Models
{
    public partial class SubscriptionLanguages
    {
        public long Id { get; set; }
        public int SubId { get; set; }
        public int LanguageId { get; set; }

        public virtual Languages Language { get; set; }
        public virtual SubscriptionPackages Sub { get; set; }
    }
}
