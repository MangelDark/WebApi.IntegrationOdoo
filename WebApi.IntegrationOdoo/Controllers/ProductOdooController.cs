using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.IntegrationOdoo.IService;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.IntegrationOdoo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductOdooController : ControllerBase
    {

        private readonly IProductOdooRepository _product;
        public ProductOdooController(IProductOdooRepository product)
        {
            _product = product;
        }
        // GET: api/<ProductOdooController>
        [HttpGet]
        public async Task<IActionResult> Get_All_Products()
        {
            var data = await _product.Get_All();
            return Ok(data);
        }


        // GET api/<ProductOdooController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(long id)
        {
            var data = await _product.Get_For_Id(id);
            return Ok(data);
        }

        // POST api/<ProductOdooController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ProductOdooController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductOdooController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
