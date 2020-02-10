using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        IProductService _prodcutService;
        public ProductsController(IProductService productService)
        {
            _prodcutService = productService;
        }

        [HttpGet("getall")]
        public IActionResult GetList()
        {
            var result = _prodcutService.GetList();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }
        [HttpGet("Getlistbycategoryıd")]
        public IActionResult GetListByCategoryId(int CategoryId)
        {
            var result = _prodcutService.GetListByCategory(CategoryId);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }
        [HttpPost("add")]
        public IActionResult Add(Product product)
        {
            var result = _prodcutService.Add(product);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
            
        }
        [HttpPost("delete")]
        public IActionResult Delete(Product product)
        {
            var result = _prodcutService.Delete(product);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);

        }
        [HttpPost("update")]
        public IActionResult Update(Product product)
        {
            var result = _prodcutService.Update(product);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);

        }

    }
}