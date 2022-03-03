using System;
using System.Collections.Generic;

namespace Backstage.Models
{
    public partial class AssetGenres
    {
        public long Id { get; set; }
        public long AssetId { get; set; }
        public int GenreId { get; set; }

        public virtual Asset Asset { get; set; }
        public virtual EpgGenre Genre { get; set; }
    }
}
