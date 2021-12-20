using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendEcom.Models
{
    public partial class CartViewModel
    {
        public Guid? CustomerId { get; set; }
        public int? Quantity { get; set; }
        public Guid? ProductVariationId { get; set; }
        public Guid? ProductId { get; set; }
        public string PName { get; set; }
        public string Brand { get; set; }
        public decimal? Price { get; set; }
        public string PrimaryImageName { get; set; }
        public decimal TotalAmount { get; set; }

    }
}
