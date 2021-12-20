using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontendEcom.Models
{
    public class ProductListViewModel
    {
        public Guid ProductId { get; set; }
        public Guid? Sellerid { get; set; }
        public string PName { get; set; }
        public string PDescription { get; set; }
        public bool? IsCancelable { get; set; }
        public bool? IsReturnable { get; set; }
        public string Brand { get; set; }

        public Guid ProductVariationId { get; set; }
        public int? QunatityAvailable { get; set; }
        public decimal? Price { get; set; }
        public string VariationMetadata { get; set; }
        public string ImagePath { get; set; }
        public string PrimaryImageName { get; set; }

        public string Review { get; set; }
        public double? Rating { get; set; }
    }
}

