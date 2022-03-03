using System;
using System.Collections.Generic;

namespace Backstage.Models
{
    public partial class VwAppFileDetails
    {
        public long IappId { get; set; }
        public long FileId { get; set; }
        public int MajorVersion { get; set; }
        public int MinorVersion { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public string FilePath { get; set; }
        public int? FileSize { get; set; }
        public DateTime ModifiedTime { get; set; }
        public string Name { get; set; }
        public int CycleTime { get; set; }
        public int SatValue { get; set; }
        public long BuildId { get; set; }
        public byte[] FileData { get; set; }
        public string Itvid { get; set; }
        public bool IngestionStatus { get; set; }
    }
}
