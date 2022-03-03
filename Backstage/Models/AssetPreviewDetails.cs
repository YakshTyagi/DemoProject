using System;
using System.Collections.Generic;

namespace Backstage.Models
{
    public partial class AssetPreviewDetails
    {
        public long Id { get; set; }
        public long AssetId { get; set; }
        public string ContentFilename { get; set; }
        public TimeSpan Duration { get; set; }
        public string ScreenFormat { get; set; }
        public string AudioType { get; set; }
        public bool IsHd { get; set; }
        public int? DeltaIpId { get; set; }

        public virtual Asset Asset { get; set; }
        public virtual ElementalDeltaIps DeltaIp { get; set; }
    }
}
