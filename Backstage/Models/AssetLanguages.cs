using System;
using System.Collections.Generic;

namespace Backstage.Models
{
    public partial class AssetLanguages
    {
        public long Id { get; set; }
        public long AssetId { get; set; }
        public int LanguageId { get; set; }

        public virtual Asset Asset { get; set; }
        public virtual Languages Language { get; set; }
    }
}
