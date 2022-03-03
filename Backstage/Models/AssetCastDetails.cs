using System;
using System.Collections.Generic;

namespace Backstage.Models
{
    public partial class AssetCastDetails
    {
        public long Id { get; set; }
        public long CastId { get; set; }
        public int LanguageId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual AssetCast Cast { get; set; }
        public virtual Languages Language { get; set; }
    }
}
