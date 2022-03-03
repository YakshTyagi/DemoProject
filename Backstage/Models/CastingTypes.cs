using System;
using System.Collections.Generic;

namespace Backstage.Models
{
    public partial class CastingTypes
    {
        public CastingTypes()
        {
            AssetCast = new HashSet<AssetCast>();
        }

        public int Id { get; set; }
        public string CastType { get; set; }
        public int CastOrder { get; set; }

        public virtual ICollection<AssetCast> AssetCast { get; set; }
    }
}
