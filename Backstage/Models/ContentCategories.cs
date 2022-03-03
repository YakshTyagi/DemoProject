using System;
using System.Collections.Generic;

namespace Backstage.Models
{
    public partial class ContentCategories
    {
        public ContentCategories()
        {
            AssetTitleDetails = new HashSet<AssetTitleDetails>();
        }

        public int CatId { get; set; }
        public string Category { get; set; }

        public virtual ICollection<AssetTitleDetails> AssetTitleDetails { get; set; }
    }
}
