using System;
using System.Collections.Generic;

namespace Backstage.Models
{
    public partial class ServiceDescriptions
    {
        public int Id { get; set; }
        public int ServiceId { get; set; }
        public int LanguageId { get; set; }
        public string TitleSortName { get; set; }
        public string TitleBrief { get; set; }
        public string TitleMedium { get; set; }
        public string TitleLong { get; set; }
        public string SummaryShort { get; set; }
        public string SummaryMedium { get; set; }
        public string SummaryLong { get; set; }

        public virtual Languages Language { get; set; }
        public virtual Services Service { get; set; }
    }
}
