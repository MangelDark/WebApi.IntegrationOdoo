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
    public class AccountOdooController : ControllerBase
    {

        private readonly IAccountOdooRepository _account;
        public AccountOdooController(IAccountOdooRepository account)
        {
            _account = account;
        }
        [HttpGet]
        public async Task<IActionResult> Get_All_Account()
        {
            var result = await _account.Get_All();

            return Ok(result);

        }
        [HttpGet("Id")]
        public async Task<IActionResult> Get_Id_Account(long Id)
        {
            var result = await _account.Get_For_Id(Id);
            return Ok(result);
        }


    }
}
