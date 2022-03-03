using System;
using System.Collections.Generic;

namespace Backstage.Models
{
    public partial class AssetCast
    {
        public AssetCast()
        {
            AssetCastDetails = new HashSet<AssetCastDetails>();
        }

        public long Id { get; set; }
        public int CastTypeId { get; set; }
        public long AssetId { get; set; }

        public virtual Asset Asset { get; set; }
        public virtual CastingTypes CastType { get; set; }
        public virtual ICollection<AssetCastDetails> AssetCastDetails { get; set; }
    }
}
