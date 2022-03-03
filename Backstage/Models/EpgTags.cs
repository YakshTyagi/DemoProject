using System;
using System.Collections.Generic;

namespace Backstage.Models
{
    public partial class EpgTags
    {
        public long Id { get; set; }
        public long EventId { get; set; }
        public string Keywords { get; set; }
        public string Provider { get; set; }
        public int? YearOfRelease { get; set; }
        public string MarketingMsg { get; set; }
        public string OppvPurchaseCode { get; set; }
        public int? Price { get; set; }
        public string Missedcall { get; set; }
        public string Programmeid { get; set; }
        public int? Episodeid { get; set; }
        public string ShowcaseImageUrl { get; set; }

        public virtual EpgEvents Event { get; set; }
    }
}
