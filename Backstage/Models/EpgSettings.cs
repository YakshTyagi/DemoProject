using System;
using System.Collections.Generic;

namespace Backstage.Models
{
    public partial class EpgSettings
    {
        public long Id { get; set; }
        public long EventId { get; set; }
        public int ShowId { get; set; }
        public int RatingId { get; set; }
        public bool IsCatchup { get; set; }
        public int GenreId { get; set; }
        public bool Blackout { get; set; }
        public bool Downloadable { get; set; }
        public int? CaTemplateId { get; set; }
        public bool? RestartTvAllowed { get; set; }
        public bool IsCloudDvr { get; set; }
        public int? PrimaryGenreId { get; set; }

        public virtual EpgEvents Event { get; set; }
        public virtual EpgGenre Genre { get; set; }
        public virtual EpgGenre PrimaryGenre { get; set; }
        public virtual Ratings Rating { get; set; }
        public virtual ShowTypes Show { get; set; }
    }
}
