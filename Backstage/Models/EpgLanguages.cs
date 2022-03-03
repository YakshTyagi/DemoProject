using System;
using System.Collections.Generic;

namespace Backstage.Models
{
    public partial class EpgLanguages
    {
        public EpgLanguages()
        {
            EpgDescriptions = new HashSet<EpgDescriptions>();
        }

        public int LanguageId { get; set; }
        public string LanguageName { get; set; }
        public string LanguageCode { get; set; }

        public virtual ICollection<EpgDescriptions> EpgDescriptions { get; set; }
    }
}
