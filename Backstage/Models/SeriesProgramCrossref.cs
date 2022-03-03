using System;
using System.Collections.Generic;

namespace Backstage.Models
{
    public partial class SeriesProgramCrossref
    {
        public long Id { get; set; }
        public long SeriesId { get; set; }
        public long ProgramId { get; set; }

        public virtual Asset Series { get; set; }
    }
}
