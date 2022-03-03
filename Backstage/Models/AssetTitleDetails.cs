using System;
using System.Collections.Generic;

namespace Backstage.Models
{
    public partial class AssetTitleDetails
    {
        public long Id { get; set; }
        public long AssetId { get; set; }
        public int? CountryId { get; set; }
        public int? ShowId { get; set; }
        public string Keywords { get; set; }
        public int? Msorating { get; set; }
        public int Year { get; set; }
        public bool? IsDownloadable { get; set; }
        public int? DownloadExpiry { get; set; }
        public string Provider { get; set; }
        public bool? IsClosedCaptioning { get; set; }
        public int? MaxConcurrentStreams { get; set; }
        public int? EpisodeId { get; set; }
        public string EpisodeName { get; set; }
        public int? PlatformId { get; set; }
        public int CatId { get; set; }
        public int RatingId { get; set; }
        public int? RentalExpiry { get; set; }
        public bool? IsShowcase { get; set; }
        public int? PGenreId { get; set; }

        public virtual Asset Asset { get; set; }
        public virtual ContentCategories Cat { get; set; }
        public virtual Countries Country { get; set; }
        public virtual EpgGenre PGenre { get; set; }
        public virtual OttPlatforms Platform { get; set; }
        public virtual Ratings Rating { get; set; }
        public virtual ShowTypes Show { get; set; }
    }
}
