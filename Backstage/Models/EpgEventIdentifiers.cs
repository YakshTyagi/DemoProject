using System;
using System.Collections.Generic;

namespace Backstage.Models
{
    public partial class EpgEventIdentifiers
    {
        public long Id { get; set; }
        public long EventId { get; set; }
        public string SlotId { get; set; }
        public string Title { get; set; }
        public long IconId { get; set; }

        public virtual EpgEvents Event { get; set; }
        public virtual EpgPoster Icon { get; set; }
    }
}
