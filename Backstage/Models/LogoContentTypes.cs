using System;
using System.Collections.Generic;

namespace Backstage.Models
{
    public partial class LogoContentTypes
    {
        public LogoContentTypes()
        {
            AssetLogos = new HashSet<AssetLogos>();
            ServiceLogos = new HashSet<ServiceLogos>();
        }

        public int Id { get; set; }
        public string ContentType { get; set; }
        public string ContentName { get; set; }

        public virtual ICollection<AssetLogos> AssetLogos { get; set; }
        public virtual ICollection<ServiceLogos> ServiceLogos { get; set; }
    }
}
