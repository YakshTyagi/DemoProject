using System;
using System.Collections.Generic;

namespace Backstage.Models
{
    public partial class Iapp
    {
        public Iapp()
        {
            IappBuildVersions = new HashSet<IappBuildVersions>();
            IappFileMaster = new HashSet<IappFileMaster>();
            Ischedule = new HashSet<Ischedule>();
        }

        public long IappId { get; set; }
        public string Itvid { get; set; }
        public string AppName { get; set; }
        public long CycleTime { get; set; }
        public long SatValue { get; set; }

        public virtual ICollection<IappBuildVersions> IappBuildVersions { get; set; }
        public virtual ICollection<IappFileMaster> IappFileMaster { get; set; }
        public virtual ICollection<Ischedule> Ischedule { get; set; }
    }
}
