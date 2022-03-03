using System;
using System.Collections.Generic;

namespace Backstage.Models
{
    public partial class VwEpgEventInfo
    {
        public long EventId { get; set; }
        public int ServiceId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public long FileId { get; set; }
        public string SlotId { get; set; }
        public string Title { get; set; }
        public string IngestUrl { get; set; }
        public int ShowId { get; set; }
        public int RatingId { get; set; }
        public bool IsCatchup { get; set; }
        public int GenreId { get; set; }
        public string Keywords { get; set; }
        public string Provider { get; set; }
        public string Actor { get; set; }
        public string Producer { get; set; }
        public string Director { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }
        public int GenreId1 { get; set; }
        public string GenreName { get; set; }
        public int ShowId1 { get; set; }
        public string ShowType { get; set; }
        public long IconId { get; set; }
        public long IdentiId { get; set; }
        public long TagId { get; set; }
        public long SettingId { get; set; }
        public long CastId { get; set; }
        public bool Blackout { get; set; }
        public int? YearOfRelease { get; set; }
        public string MarketingMsg { get; set; }
        public string OppvPurchaseCode { get; set; }
        public bool Downloadable { get; set; }
        public int? Price { get; set; }
        public string Missedcall { get; set; }
        public int? CaTemplateId { get; set; }
        public string Programmeid { get; set; }
        public int? Episodeid { get; set; }
        public bool? RestartTvAllowed { get; set; }
        public bool IsCloudDvr { get; set; }
        public int? PrimaryGenreId { get; set; }
        public string ShowcaseImageUrl { get; set; }
    }
}
