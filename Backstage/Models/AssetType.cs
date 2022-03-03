using System;
using System.Collections.Generic;

namespace Backstage.Models
{
    public partial class AssetType
    {
        public AssetType()
        {
            Asset = new HashSet<Asset>();
        }

        public int Id { get; set; }
        public string Type { get; set; }

        public virtual ICollection<Asset> Asset { get; set; }
    }
}
