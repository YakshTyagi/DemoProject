using System;
using System.Collections.Generic;

namespace Backstage.Models
{
    public partial class IappFileDetails
    {
        public long FileId { get; set; }
        public long BuildId { get; set; }
        public int MajorVersion { get; set; }
        public int MinorVersion { get; set; }
        public long FileMasterId { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public string FilePath { get; set; }
        public int? FileSize { get; set; }
        public int CycleTime { get; set; }
        public int SatValue { get; set; }
        public DateTime ModifiedTime { get; set; }
        public long ModifiedBy { get; set; }
        public bool IngestionStatus { get; set; }

        public virtual IappFileMaster FileMaster { get; set; }
        public virtual IappBuildVersions IappBuildVersions { get; set; }
        public virtual Users ModifiedByNavigation { get; set; }
        public virtual IappFiles IappFiles { get; set; }
    }
}
