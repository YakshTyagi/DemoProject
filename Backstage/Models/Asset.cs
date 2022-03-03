using System;
using System.Collections.Generic;

namespace Backstage.Models
{
    public partial class Asset
    {
        public Asset()
        {
            AssetAdditionalDetails = new HashSet<AssetAdditionalDetails>();
            AssetCast = new HashSet<AssetCast>();
            AssetGenres = new HashSet<AssetGenres>();
            AssetLanguages = new HashSet<AssetLanguages>();
            AssetLogos = new HashSet<AssetLogos>();
            AssetMovieDetails = new HashSet<AssetMovieDetails>();
            AssetOffers = new HashSet<AssetOffers>();
            AssetPreviewDetails = new HashSet<AssetPreviewDetails>();
            AssetTitleDescriptions = new HashSet<AssetTitleDescriptions>();
            AssetTitleDetails = new HashSet<AssetTitleDetails>();
            BrandSeriesCrossrefBrand = new HashSet<BrandSeriesCrossref>();
            BrandSeriesCrossrefSeries = new HashSet<BrandSeriesCrossref>();
            SeriesProgramCrossref = new HashSet<SeriesProgramCrossref>();
        }

        public long AssetId { get; set; }
        public string PackageAssetId { get; set; }
        public string PkgDescriptionEng { get; set; }
        public string PkgDescriptionHin { get; set; }
        public int PkgVerMaj { get; set; }
        public int PkgVerMin { get; set; }
        public DateTime CreationDateTime { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public int AssetTypeId { get; set; }
        public int? EncryptionTypeId { get; set; }

        public virtual AssetType AssetType { get; set; }
        public virtual SubscriptionPolicies EncryptionType { get; set; }
        public virtual ICollection<AssetAdditionalDetails> AssetAdditionalDetails { get; set; }
        public virtual ICollection<AssetCast> AssetCast { get; set; }
        public virtual ICollection<AssetGenres> AssetGenres { get; set; }
        public virtual ICollection<AssetLanguages> AssetLanguages { get; set; }
        public virtual ICollection<AssetLogos> AssetLogos { get; set; }
        public virtual ICollection<AssetMovieDetails> AssetMovieDetails { get; set; }
        public virtual ICollection<AssetOffers> AssetOffers { get; set; }
        public virtual ICollection<AssetPreviewDetails> AssetPreviewDetails { get; set; }
        public virtual ICollection<AssetTitleDescriptions> AssetTitleDescriptions { get; set; }
        public virtual ICollection<AssetTitleDetails> AssetTitleDetails { get; set; }
        public virtual ICollection<BrandSeriesCrossref> BrandSeriesCrossrefBrand { get; set; }
        public virtual ICollection<BrandSeriesCrossref> BrandSeriesCrossrefSeries { get; set; }
        public virtual ICollection<SeriesProgramCrossref> SeriesProgramCrossref { get; set; }
    }
}
