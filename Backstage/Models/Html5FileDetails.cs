using System;
using System.Collections.Generic;

namespace Backstage.Models
{
    public partial class Html5FileDetails
    {
        public long FileId { get; set; }
        public long BuildId { get; set; }
        public int MajorVersion { get; set; }
        public int MinorVersion { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public string FilePath { get; set; }
        public long Size { get; set; }
        public bool IngestionStatus { get; set; }

        public virtual Html5AppBuildVersions Html5AppBuildVersions { get; set; }
        public virtual Html5Files Html5Files { get; set; }
    }
}
