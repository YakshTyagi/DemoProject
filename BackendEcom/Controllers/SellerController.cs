using BackendEcom.IRepository;
using BackendEcom.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendEcom.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class SellerController : ControllerBase
    {
        private readonly SellerInterface repository;
        public SellerController(SellerInterface _repository)
        {
            repository = _repository;
        }
        [HttpGet]
        public ActionResult Get()
        {
            var response = repository.GetSeller();
            if (response != null)
            {
                return Ok(response);
            }
            else
            {
                return BadRequest("Record not found.");
            }

        }
        [HttpPost]
        public ActionResult Insert(Seller model)
        {
            var response = repository.Insert(model);
            if (response == "User saved successfully.")
            {
                return Ok(response);
            }
            else
            {
                return BadRequest(response);
            }

        }
        [HttpGet("{id}")]
        public ActionResult<Seller> GetBySellerGuid(Guid id)
        {
            var response = repository.GetBySellerGuid(id);
            if (response != null)
            {
                return Ok(response);
            }
            else
            {
                return BadRequest("Record not found.");
            }
        }

        [HttpPost]
        public ActionResult ProductAdd([FromBody] ProductUploadViewModel model)
        {
            ResponsePara responsePara = new ResponsePara();

            responsePara = repository.SetProduct(model);
            if (responsePara.SuccessMessage == "Product added successfuly in Product variation Table")
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