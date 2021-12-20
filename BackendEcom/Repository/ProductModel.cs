using BackendEcom.IRepository;
using BackendEcom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace BackendEcom.Repository
{
    public class ProductModel : ProductInterface
    {
        private readonly Demo_ProjectContext context;
        public ProductModel(Demo_ProjectContext _context)
        {
            context = _context;
        }



        public IEnumerable<ProductList> GetProduct()
        {
            var response = (from prod in context.Product
                            join pv in context.ProductVariation on prod.ProductId equals pv.ProductId
                            select new ProductList
                            {
                                ProductId = prod.ProductId,
                                PName = prod.PName,
                                PDescription = prod.PDescription,
                                IsCancelable = prod.IsCancelable,
                                IsReturnable = prod.IsReturnable,
                                Brand = prod.Brand,
                                ProductVariationId = pv.ProductVariationId,
                                QunatityAvailable = pv.QunatityAvailable,
                                Price = pv.Price,
                                VariationMetadata = pv.VariationMetadata,
                                PrimaryImageName = pv.PrimaryImageName,
                            }).ToList();



            return response;
        }


        //select p.ProductID, p.P_Name, P_Description, p.Is_Cancelable, p.Is_Returnable
        //, p.Brand, pv.ProductVariationID, pv.Qunatity_Available, pv.Price, pv.Variation_Metadata,
        //pv.Primary_Image_Name, pr.Review, pr.Rating
        //from Product p inner join Product_Variation pv on
        //p.ProductID= pv.ProductID
        //inner join Product_Review pr on p.ProductID= pr.ProductID




        public ResponsePara AddToCart(Cart model)
        {
            ResponsePara responsePara = new ResponsePara();
            try
            {
                var isExistingProd = (from c in context.Cart
                                      where c.ProductId == model.ProductId
                                      select c).FirstOrDefault();
                if (isExistingProd == null)
                {
                    context.Cart.Add(model);
                    context.SaveChanges();
                    responsePara.SuccessMessage = "Prod added to cart successfully.";
                    //responsePara.id = model.Id;
                }
                else
                {
                    responsePara.SuccessMessage = "Prod already added to cart.";
                }

            }
            catch (Exception ex)
            {
                responsePara.ErrorMessage = "Insertion Failed due to=" + ex.Message + ".";
            }

            return responsePara;
        }

        //public ResponsePara DeleteCartWhenOrderPlaced(Cart model)
        //{
        //    ResponsePara responsePara = new ResponsePara();
        //    try
        //    {
        //        var isExistingRecord = (from c in context.Cart
        //                                where c.ProductId == model.ProductId
        //                                select c).FirstOrDefault();
        //        if (isExistingRecord == null)
        //        {
        //            context.Cart.Remove(isExistingRecord);
        //            context.SaveChanges();
        //            responsePara.SuccessMessage = "Record removed from cart successfully.";
        //            //responsePara.id = model.Id;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        responsePara.ErrorMessage = "Record does not removed due to=" + ex.Message + ".";
        //    }

        //    return responsePara;
        //}



        //public IEnumerable<Cart> GetCart(string custId)
        //{
        //    Guid guid = new Guid();
        //    guid=Guid.Parse(custId);
        //    var response = (from c in context.Cart       ERROR HERE.
        //                    where c.CustomerId == guid
        //                    select c).FirstOrDefault();
        //     return (IEnumerable<Cart>)response;
        //}

        public IEnumerable<CartViewModel> GetCart(string custId)
        {
            Guid guid = new Guid();
            guid = Guid.Parse(custId);
            var response = (from c in context.Cart
                            join p in context.Product on c.ProductId equals p.ProductId
                            join pv in context.ProductVariation on c.ProductVariationId equals pv.ProductVariationId
                            where c.CustomerId == guid
                            select new CartViewModel
                            {
                                CustomerId = c.CustomerId,
                                Quantity = c.Quantity,
                                ProductId = c.ProductId,
                                ProductVariationId = c.ProductVariationId,
                                PName = p.PName,
                                Brand = p.Brand,
                                Price = pv.Price,
                                PrimaryImageName = pv.PrimaryImageName
                            }).ToList();


            return response;
        }

        public ResponsePara SetOrder(OrderTable model)
        {
            Cart cart = new Cart();
            cart.ProductId = model.ProductId;
            ResponsePara responsePara = new ResponsePara();
            try
            {

                context.OrderTable.Add(model);
                context.SaveChanges();

                var isExistingRecord = (from c in context.Cart
                                        where c.ProductId == cart.ProductId
                                        select c).FirstOrDefault();
                if (isExistingRecord != null)
                {
                    context.Cart.Remove(isExistingRecord);
                    context.SaveChanges();

                }
                responsePara.SuccessMessage = "Order placed successfully.";

            }
            catch (Exception ex)
            {
                var isExistingRecord = (from c in context.OrderTable
                                        where c.ProductId == model.ProductId
                                        select c).FirstOrDefault();
                if (isExistingRecord != null)
                {
                    context.OrderTable.Remove(model);
                    context.SaveChanges();
                }
                responsePara.ErrorMessage = "Order Failed due to=" + ex.Message + ".";
            }

            return responsePara;
        }


    }
}
