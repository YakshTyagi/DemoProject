using System;
using System.Collections.Generic;

namespace Backstage.Models
{
    public partial class VwEpgLanguages
    {
        public long Id { get; set; }
        public long EventId { get; set; }
        public int LanguageId { get; set; }
        public string LanguageName { get; set; }
    }
}
