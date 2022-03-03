using System;
using System.Collections.Generic;

namespace Backstage.Models
{
    public partial class ElementalDeltaIps
    {
        public ElementalDeltaIps()
        {
            AssetMovieDetails = new HashSet<AssetMovieDetails>();
            AssetPreviewDetails = new HashSet<AssetPreviewDetails>();
            ServiceConfigurations = new HashSet<ServiceConfigurations>();
        }

        public int IpId { get; set; }
        public string ElementalDeltaIp { get; set; }
        public int Port { get; set; }
        public string ServerName { get; set; }
        public string DomainName { get; set; }
        public string CdnLiveUrlprefix { get; set; }
        public string CdnCatchupUrlprefix { get; set; }
        public string CdnVodurlPrefix { get; set; }

        public virtual ICollection<AssetMovieDetails> AssetMovieDetails { get; set; }
        public virtual ICollection<AssetPreviewDetails> AssetPreviewDetails { get; set; }
        public virtual ICollection<ServiceConfigurations> ServiceConfigurations { get; set; }
    }
}
