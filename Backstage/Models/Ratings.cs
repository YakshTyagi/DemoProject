using System;
using System.Collections.Generic;

namespace Backstage.Models
{
    public partial class Ratings
    {
        public Ratings()
        {
            AssetTitleDetails = new HashSet<AssetTitleDetails>();
            EpgSettings = new HashSet<EpgSettings>();
        }

        public int RatingId { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }

        public virtual ICollection<AssetTitleDetails> AssetTitleDetails { get; set; }
        public virtual ICollection<EpgSettings> EpgSettings { get; set; }
    }
}
