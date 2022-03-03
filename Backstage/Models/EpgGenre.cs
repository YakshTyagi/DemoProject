using System;
using System.Collections.Generic;

namespace Backstage.Models
{
    public partial class EpgGenre
    {
        public EpgGenre()
        {
            AssetGenres = new HashSet<AssetGenres>();
            AssetTitleDetails = new HashSet<AssetTitleDetails>();
            EpgSettingsGenre = new HashSet<EpgSettings>();
            EpgSettingsPrimaryGenre = new HashSet<EpgSettings>();
            ServiceGenres = new HashSet<ServiceGenres>();
        }

        public int GenreId { get; set; }
        public string GenreName { get; set; }

        public virtual ICollection<AssetGenres> AssetGenres { get; set; }
        public virtual ICollection<AssetTitleDetails> AssetTitleDetails { get; set; }
        public virtual ICollection<EpgSettings> EpgSettingsGenre { get; set; }
        public virtual ICollection<EpgSettings> EpgSettingsPrimaryGenre { get; set; }
        public virtual ICollection<ServiceGenres> ServiceGenres { get; set; }
    }
}
