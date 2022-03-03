using System;
using System.Collections.Generic;

namespace Backstage.Models
{
    public partial class EpgAudioLanguages
    {
        public long Id { get; set; }
        public long EventId { get; set; }
        public int LanguageId { get; set; }

        public virtual EpgEvents Event { get; set; }
        public virtual Languages Language { get; set; }
    }
}
