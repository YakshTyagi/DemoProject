using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackendEcom.Models;

namespace BackendEcom.IRepository
{
    public interface ProductInterface
    {
        public IEnumerable<ProductList> GetProduct();
        public IEnumerable<CartViewModel> GetCart(string custId);
        public ResponsePara AddToCart(Cart model);

        public ResponsePara SetOrder(OrderTable model);


       


    }
}
