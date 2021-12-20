using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FrontendEcom.Models
{
    public class SellerRegistration
    {
        [Required ]
        public string Gst { get; set; }
        [Required]
        public decimal CompanyContact { get; set; }
        [Required]
        public string CompanyName { get; set; }
    }
}
