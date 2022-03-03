using System;
using System.Collections.Generic;

namespace Backstage.Models
{
    public partial class AssetLogos
    {
        public long Id { get; set; }
        public long AssetId { get; set; }
        public string FileName { get; set; }
        public int XResolution { get; set; }
        public int YResolution { get; set; }
        public int ContentId { get; set; }
        public string ContentCheckSum { get; set; }
        public int ContentFileSize { get; set; }

        public virtual Asset Asset { get; set; }
        public virtual LogoContentTypes Content { get; set; }
    }
}
