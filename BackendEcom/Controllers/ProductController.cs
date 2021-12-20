using BackendEcom.IRepository;
using BackendEcom.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendEcom.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly ProductInterface repository;
        public ProductController(ProductInterface _repository)
        {
            repository = _repository;
        }
        [HttpGet]
        public ActionResult Get()
        {
            var response = repository.GetProduct();
            if (response != null)
            {
                return Ok(response);
            }
            else
            {
                return BadRequest("Records not found.");
            }
        }

        [HttpPost]

        public ActionResult AddToCart([FromBody] Cart model)
        {
            ResponsePara responsePara = new ResponsePara();

            responsePara = repository.AddToCart(model);
            if (responsePara.SuccessMessage == "Prod added to cart successfully.")
            {
                return Ok(responsePara);
            }
            else if (responsePara.SuccessMessage == "Prod already added to cart.")
            {
                return Ok(responsePara);
            }
            else
            {
                return BadRequest(responsePara);
            }
        }

        [HttpGet("{custId}")]
        public ActionResult GetCartRecord(string custId)
        {
            var response = repository.GetCart(custId);
            if (response != null)
            {
                return Ok(response);
            }
            else
            {
                return BadRequest("Records not found.");
            }
        }

        [HttpPost]
        public ActionResult PlaceOrder(OrderTable model)
        {
            ResponsePara responsePara = new ResponsePara();
            responsePara = repository.SetOrder(model);
            if (responsePara.SuccessMessage == "Order placed successfully.")
            {
                return Ok(responsePara);
            }
            else
            {
                return BadRequest(responsePara);
            }



        }

    }
}
