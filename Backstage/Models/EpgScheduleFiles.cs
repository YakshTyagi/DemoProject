using System;
using System.Collections.Generic;

namespace Backstage.Models
{
    public partial class EpgScheduleFiles
    {
        public EpgScheduleFiles()
        {
            EpgEvents = new HashSet<EpgEvents>();
        }

        public long FileId { get; set; }
        public string FileName { get; set; }
        public DateTime EpgDate { get; set; }
        public int ServiceReference { get; set; }
        public DateTime ImportDate { get; set; }
        public bool IngestionStatus { get; set; }
        public bool IsCurrentVersion { get; set; }

        public virtual Services ServiceReferenceNavigation { get; set; }
        public virtual ICollection<EpgEvents> EpgEvents { get; set; }
    }
}
