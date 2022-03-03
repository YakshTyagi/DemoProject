using System;
using System.Collections.Generic;

namespace Backstage.Models
{
    public partial class BrandSeriesCrossref
    {
        public long Id { get; set; }
        public long BrandId { get; set; }
        public long SeriesId { get; set; }

        public virtual Asset Brand { get; set; }
        public virtual Asset Series { get; set; }
    }
}
