using System;
using System.Collections.Generic;

namespace Backstage.Models
{
    public partial class ServiceGenres
    {
        public long Id { get; set; }
        public int GenreId { get; set; }
        public int ServiceId { get; set; }

        public virtual EpgGenre Genre { get; set; }
        public virtual Services Service { get; set; }
    }
}
