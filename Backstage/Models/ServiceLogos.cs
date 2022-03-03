using System;
using System.Collections.Generic;

namespace Backstage.Models
{
    public partial class ServiceLogos
    {
        public long BoxcoverId { get; set; }
        public int ServiceId { get; set; }
        public string FileName { get; set; }
        public int XResolution { get; set; }
        public int YResolution { get; set; }
        public int ContentId { get; set; }
        public string ContentCheckSum { get; set; }
        public int ContentFileSize { get; set; }

        public virtual LogoContentTypes Content { get; set; }
        public virtual Services Service { get; set; }
    }
}
