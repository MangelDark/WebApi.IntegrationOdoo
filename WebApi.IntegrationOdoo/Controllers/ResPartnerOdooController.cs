﻿using Microsoft.AspNetCore.Mvc;
using PortaCapena.OdooJsonRpcClient.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.IntegrationOdoo.IService;
using WebApi.IntegrationOdoo.Service;
using WebApi.IntegrationOdoo.ViewModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.IntegrationOdoo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResPartnerOdooController : ControllerBase
    {

        private readonly IResPartnerOdooRepository _service;
        public ResPartnerOdooController(IResPartnerOdooRepository service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<IActionResult> Get_All()
        {
            var result = await _service.Get_All();
            return Ok(result);

        }
        [HttpGet("Id")]
        public async Task<IActionResult> Get_Id(long Id)
        {
            var result = await _service.Get_For_Id(Id);
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> Create_ResPartner([FromBody] ResPartnerViewModel model)
        {
            var result = await _service.Create_ResPartner(model);
            return Ok(result);
        }

    }
}
