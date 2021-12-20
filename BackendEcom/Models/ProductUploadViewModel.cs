using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace BackendEcom.Models
{
    public class ProductUploadViewModel
    {
                                                         
        [Required(ErrorMessage ="Product name is required")]
        
        public string Name { get; set; }
        [Required(ErrorMessage = "Description  is required")]
        public string Description { get; set; }
        public bool IsCancelable { get; set; }
        public bool IsReturnable { get; set; }
        [Required(ErrorMessage = "Brand name is required")]
        public string Brand { get; set; }
        [Required(ErrorMessage = "QunatityAvailable is required")]
        public int? QunatityAvailable { get; set; }
        [Required(ErrorMessage = "Price is required")]
        public decimal? Price { get; set; }
        [Required(ErrorMessage = "VariationMetadata is required")]
        public string VariationMetadata { get; set; }

        public string ImagePath { get; set; }
       
        public Guid? Sellerid { get; set; }
    }
}
