using System;
using System.Collections.Generic;

namespace Backstage.Models
{
    public partial class AssetTitleDescriptions
    {
        public long Id { get; set; }
        public long AssetId { get; set; }
        public int LanguageId { get; set; }
        public string TitleSortName { get; set; }
        public string TitleBrief { get; set; }
        public string TitleMedium { get; set; }
        public string TitleLong { get; set; }
        public string SummaryShort { get; set; }
        public string SummaryMedium { get; set; }
        public string SummaryLong { get; set; }

        public virtual Asset Asset { get; set; }
        public virtual Languages Language { get; set; }
    }
}
