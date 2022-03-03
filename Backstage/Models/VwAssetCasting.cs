using System;
using System.Collections.Generic;

namespace Backstage.Models
{
    public partial class VwAssetCasting
    {
        public long CastId { get; set; }
        public int LanguageId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long Id { get; set; }
        public long AssetId { get; set; }
        public int CastTypeId { get; set; }
        public string CastType { get; set; }
        public int CastOrder { get; set; }
    }
}
