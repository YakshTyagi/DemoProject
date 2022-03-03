using System;
using System.Collections.Generic;

namespace Backstage.Models
{
    public partial class Html5Apps
    {
        public Html5Apps()
        {
            Html5AppBuildVersions = new HashSet<Html5AppBuildVersions>();
        }

        public long ApplicationId { get; set; }
        public string ApplicationName { get; set; }

        public virtual ICollection<Html5AppBuildVersions> Html5AppBuildVersions { get; set; }
    }
}
