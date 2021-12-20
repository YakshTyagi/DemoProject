using BackendEcom.Models;
using FrontendEcom.HelperClass;
using FrontendEcom.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace FrontendEcom.Controllers
{
    public class ProductController : Controller
    {
        Helper api = new Helper();
        HttpClient client;
        //[Route("")]
        [HttpGet]
        public async Task<IActionResult> ProductList()
        {
            //    if (HttpContext.Session.GetString("UserId") == null)
            //    {
            //        TempData["UserName"] = " Guest User";
            //    }

            List<ProductListViewModel> productLists = new List<ProductListViewModel>();
            client = api.Initial();
            HttpResponseMessage response = await client.GetAsync("api/Product/Get");
            if (response.IsSuccessStatusCode)
            {
                var result = response.Content.ReadAsStringAsync().Result;
                productLists = JsonConvert.DeserializeObject<List<ProductListViewModel>>(result);
            }
            return View(productLists);
        }

        [HttpPost]
        public IActionResult ProductList(string ProductId, string ProductVariationId, int qnty)
        {

            if (HttpContext.Session.GetString("UserId") == null)
            {
                ViewBag.SessionMsg = "Session expired";
                return RedirectToAction("LoginUser", "Register");
            }
            Guid guid = new Guid();
            String custId = string.Empty;
            custId = (string)JsonConvert.DeserializeObject(HttpContext.Session.GetString("UserId"));
            Cart cart = new Cart();
            guid = Guid.Parse(custId);
            cart.CustomerId = guid;
            guid = Guid.Parse(ProductId);
            cart.ProductId = guid;
            guid = Guid.Parse(ProductVariationId);
            cart.ProductVariationId = guid;
            cart.Quantity = qnty;
            HttpResponseMessage response;
            client = api.Initial();
            var postTask = client.PostAsJsonAsync<Cart>("api/Product/AddToCart", cart);
            postTask.Wait();
            response = postTask.Result;
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("GetCart");
            }
            else
            {
                ViewBag.ProductAddError = "Product does not edit to cart";
                return View();
            }


        }

        [HttpGet]
        public async Task<IActionResult> GetCart()
        {
            List<CartViewModel> List = new List<CartViewModel>();
            client = api.Initial();
            Guid guid = new Guid();
            String custId = string.Empty;
            custId = (string)JsonConvert.DeserializeObject(HttpContext.Session.GetString("UserId"));
            //custId = "3377B050-4E07-4187-9674-54D5FFC7C259"; 
            //custId = "B4EFD4D3-FF51-48E0-8439-2DF85782A410";
            guid = Guid.Parse(custId);
            HttpResponseMessage response;
            client = api.Initial();
            response = await client.GetAsync("api/Product/GetCartRecord/" + guid);
            if (response.IsSuccessStatusCode)
            {
                var result = response.Content.ReadAsStringAsync().Result;
                List = JsonConvert.DeserializeObject<List<CartViewModel>>(result);
                foreach (var item in List)
                {
                    item.TotalAmount = (decimal)((item.Price * item.Quantity) + 69);
                }
            }
            if (List.Count == 0)
            {
                ViewBag.EmptyCart = "Uf ohh!  YOUR CART IS EMPTY";
            }
            return View(List);

        }

        [HttpPost]

        public IActionResult GetCart(string ProductId, string ProductVariationId, string Qty, string TotalAmount)
        {
            Guid guid = new Guid();
            String custId = string.Empty;
            custId = (string)JsonConvert.DeserializeObject(HttpContext.Session.GetString("UserId"));
            //custId = "B4EFD4D3-FF51-48E0-8439-2DF85782A410";

            OrderTable orderTable = new OrderTable();
            guid = Guid.Parse(custId);
            orderTable.CustomerId = guid;

            guid = Guid.Parse(ProductId);
            orderTable.ProductId = guid;

            guid = Guid.Parse(ProductVariationId);
            orderTable.ProductVariationId = guid;

            orderTable.Quantity = Convert.ToInt32(Qty);
            orderTable.AmountPaid = Convert.ToDecimal(TotalAmount);

            HttpResponseMessage response;
            client = api.Initial();
            var postTask = client.PostAsJsonAsync<OrderTable>("api/Product/PlaceOrder", orderTable);
            postTask.Wait();
            response = postTask.Result;
            if (response.IsSuccessStatusCode)
            {
                TempData["OrderSuccess"] = "Order placed successfully.";
                return RedirectToAction("ProductList");
            }
            else
            {
                ViewBag.ProductAddError = "Order does not placed.";
                return View();
            }



        }
        public IActionResult AddProduct(ProductTable productTable)
        {
            return View();
        }
    }


}

