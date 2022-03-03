using System;
using System.Collections.Generic;

namespace Backstage.Models
{
    public partial class AssetView2
    {
        public string PackageAssetId { get; set; }
        public string PkgDescriptionEng { get; set; }
        public int PkgVerMaj { get; set; }
        public int PkgVerMin { get; set; }
        public DateTime CreationDateTime { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public string ContentFilename { get; set; }
        public TimeSpan Duration { get; set; }
        public string ScreenFormat { get; set; }
        public string AudioType { get; set; }
        public bool IsHd { get; set; }
        public string ElementalDeltaIp { get; set; }
        public int Port { get; set; }
        public string TitleSortName { get; set; }
        public string LanguageName { get; set; }
        public string LanguageCode { get; set; }
        public string TitleBrief { get; set; }
        public string TitleMedium { get; set; }
        public string TitleLong { get; set; }
        public string SummaryShort { get; set; }
        public string SummaryMedium { get; set; }
        public string SummaryLong { get; set; }
        public string Keywords { get; set; }
        public string Rating { get; set; }
        public int? Msorating { get; set; }
        public int Year { get; set; }
        public bool? IsDownloadable { get; set; }
        public int? DownloadExpiry { get; set; }
        public string Provider { get; set; }
        public bool? IsClosedCaptioning { get; set; }
        public int? MaxConcurrentStreams { get; set; }
        public int? EpisodeId { get; set; }
        public string EpisodeName { get; set; }
        public string CountryName { get; set; }
        public string ShowType { get; set; }
        public string Type { get; set; }
        public string BillingId { get; set; }
        public string ProviderContentTier { get; set; }
        public int SuggestedPrice { get; set; }
        public long AssetId { get; set; }
        public int? PlatformId { get; set; }
        public int CatId { get; set; }
    }
}
