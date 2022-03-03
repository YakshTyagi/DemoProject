using System;
using System.Collections.Generic;

namespace Backstage.Models
{
    public partial class Languages
    {
        public Languages()
        {
            AssetCastDetails = new HashSet<AssetCastDetails>();
            AssetLanguages = new HashSet<AssetLanguages>();
            AssetTitleDescriptions = new HashSet<AssetTitleDescriptions>();
            EpgAudioLanguages = new HashSet<EpgAudioLanguages>();
            ServiceDescriptions = new HashSet<ServiceDescriptions>();
            ServiceLanguages = new HashSet<ServiceLanguages>();
            SubscriptionDescriptions = new HashSet<SubscriptionDescriptions>();
            SubscriptionLanguages = new HashSet<SubscriptionLanguages>();
        }

        public int LanguageId { get; set; }
        public string LanguageName { get; set; }
        public string LanguageCode { get; set; }

        public virtual ICollection<AssetCastDetails> AssetCastDetails { get; set; }
        public virtual ICollection<AssetLanguages> AssetLanguages { get; set; }
        public virtual ICollection<AssetTitleDescriptions> AssetTitleDescriptions { get; set; }
        public virtual ICollection<EpgAudioLanguages> EpgAudioLanguages { get; set; }
        public virtual ICollection<ServiceDescriptions> ServiceDescriptions { get; set; }
        public virtual ICollection<ServiceLanguages> ServiceLanguages { get; set; }
        public virtual ICollection<SubscriptionDescriptions> SubscriptionDescriptions { get; set; }
        public virtual ICollection<SubscriptionLanguages> SubscriptionLanguages { get; set; }
    }
}
