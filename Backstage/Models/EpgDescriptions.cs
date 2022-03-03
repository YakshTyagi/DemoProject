using System;
using System.Collections.Generic;

namespace Backstage.Models
{
    public partial class EpgDescriptions
    {
        public long Id { get; set; }
        public long EventId { get; set; }
        public int LanguageId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string StbDescription { get; set; }
        public string MarketingMsg { get; set; }

        public virtual EpgEvents Event { get; set; }
        public virtual EpgLanguages Language { get; set; }
    }
}
