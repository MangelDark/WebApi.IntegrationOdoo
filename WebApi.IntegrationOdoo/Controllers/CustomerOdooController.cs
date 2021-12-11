using Microsoft.AspNetCore.Mvc;
using PortaCapena.OdooJsonRpcClient.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.IntegrationOdoo.IService;
using WebApi.IntegrationOdoo.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.IntegrationOdoo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerOdooController : ControllerBase
    {

        private readonly ICustomerOdooRepository _customer;
        public CustomerOdooController(ICustomerOdooRepository customer)
        {
            _customer = customer;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _customer.Get_All();

            return Ok(result);

        }
        [HttpGet("Id")]
        public async Task<IActionResult> GetId(long Id)
        {
            var result = await _customer.Get_For_Id(Id);
            return Ok(result);
        }


    }
}
