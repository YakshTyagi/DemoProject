using System;
using System.Collections.Generic;

namespace Backstage.Models
{
    public partial class VwHtml5Applicationfiledetails
    {
        public string ApplicationName { get; set; }
        public int MinorVersion { get; set; }
        public int MajorVersion { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public string FilePath { get; set; }
        public long FileId { get; set; }
        public long Size { get; set; }
        public bool IsAppIngested { get; set; }
        public bool IngestionStatus { get; set; }
        public DateTime? LastModified { get; set; }
    }
}
