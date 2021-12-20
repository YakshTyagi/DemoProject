using BackendEcom.Models;
using FrontendEcom.HelperClass;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace FrontendEcom.Controllers
{
    public class SellerController : Controller
    {
        private IHostingEnvironment Environment;
        public SellerController(IHostingEnvironment _environment)
        {
            Environment = _environment;
        }
        Helper api = new Helper();
        HttpClient client;
        [HttpGet]
        public async Task<IActionResult> UploadProd()
        {
            if (HttpContext.Session.GetString("UserId") == null)
            {
                return RedirectToAction("LoginUser", "Register");
            }
            else
            {
                Guid LoggedUserId_ = new Guid();
                string SellerId = (string)JsonConvert.DeserializeObject(HttpContext.Session.GetString("UserId"));
                LoggedUserId_ = Guid.Parse(SellerId);

                List<Seller> sellers = new List<Seller>();
                client = api.Initial();
                HttpResponseMessage response = await client.GetAsync("api/Seller/Get");
                if (response.IsSuccessStatusCode)
                {
                    var result = response.Content.ReadAsStringAsync().Result;
                    sellers = JsonConvert.DeserializeObject<List<Seller>>(result);
                }
                var response_ = (from seller in sellers
                                 where seller.Sellerid == LoggedUserId_
                                 select seller).FirstOrDefault();
                if (response_ == null)
                {
                    ViewBag.SellerRegister = "Register yourself as seller";
                    return RedirectToAction("AssignRole", "Register");
                }

            }
            return View();
        }
        [HttpPost]
        public IActionResult UploadProd(ProductUploadViewModel model, IFormFile file)
        {
            if (file == null)
            {
                ViewBag.nullImage = "Image is required";
                return RedirectToAction("UploadProd");
            }
            string wwwPath = this.Environment.WebRootPath;
            string contentPath = this.Environment.ContentRootPath;

            string path = Path.Combine(this.Environment.WebRootPath, "Uploads");
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            List<string> uploadedFiles = new List<string>();
            string fileName = Path.GetFileName(file.FileName);
            using (FileStream stream = new FileStream(Path.Combine(path, fileName), FileMode.Create))
            {
                file.CopyTo(stream);
                uploadedFiles.Add(fileName);
                // ViewBag.Message += string.Format("<b>{0}</b> uploaded.<br />", fileName);
            }

            string rootPath = @"/Uploads/";
            string imagePath = string.Concat(rootPath, fileName);
            model.ImagePath = imagePath;
            Guid guid = new Guid();
            String custId = string.Empty;
            custId = (string)JsonConvert.DeserializeObject(HttpContext.Session.GetString("UserId"));
            //custId = "E3B7ECCC-694F-4EF5-B821-5F609CB9D37A";
            guid = Guid.Parse(custId);
            model.Sellerid = guid;
            HttpResponseMessage response;
            client = api.Initial();
            var postTask = client.PostAsJsonAsync<ProductUploadViewModel>("api/Seller/ProductAdd", model);
            postTask.Wait();
            response = postTask.Result;
            if (response.IsSuccessStatusCode)
            {
                ViewBag.ProductAdd = "Product Added successfully.";
            }
            else
            {
                ViewBag.ProductAdd = "Product does not added.";

            }
            return View();
        }

        [NonAction]
        static byte[] GetBytes(string str)
        {
            byte[] bytes = new byte[str.Length * sizeof(char)];
            System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }
    }
}
