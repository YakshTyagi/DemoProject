using System;
using System.Collections.Generic;

namespace Backstage.Models
{
    public partial class EpgGroupRecord
    {
        public long Id { get; set; }
        public long EventId { get; set; }
        public string GroupKey { get; set; }
        public string GroupType { get; set; }
        public int GroupId { get; set; }

        public virtual EpgEvents Event { get; set; }
    }
}
