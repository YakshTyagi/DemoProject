using System;
using System.Collections.Generic;

namespace Backstage.Models
{
    public partial class OttPlatforms
    {
        public OttPlatforms()
        {
            AssetTitleDetails = new HashSet<AssetTitleDetails>();
            ServiceConfigurationsAvailablePlatformCloudDvrNavigation = new HashSet<ServiceConfigurations>();
            ServiceConfigurationsPlatform = new HashSet<ServiceConfigurations>();
        }

        public int PlatformId { get; set; }
        public string PlatformName { get; set; }

        public virtual ICollection<AssetTitleDetails> AssetTitleDetails { get; set; }
        public virtual ICollection<ServiceConfigurations> ServiceConfigurationsAvailablePlatformCloudDvrNavigation { get; set; }
        public virtual ICollection<ServiceConfigurations> ServiceConfigurationsPlatform { get; set; }
    }
}
