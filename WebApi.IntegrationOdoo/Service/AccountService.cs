using FluentAssertions;
using PortaCapena.OdooJsonRpcClient;
using PortaCapena.OdooJsonRpcClient.Converters;
using PortaCapena.OdooJsonRpcClient.Request;
using PortaCapena.OdooJsonRpcClient.Shared;
using PortaCapena.OdooJsonRpcClient.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.IntegrationOdoo.Service
{
    public class AccountService : RequestTestBase
    {


        public async Task<IEnumerable<ProductProductOdooModel>> Get_All_Products()
        {
            //Primero creamos el filtro o query 
            var filters = OdooQuery<ProductProductOdooModel>.Create()
                .Select(x => new
                {
                    x.Name,
                    x.Description,
                    x.ListPrice,
                    x.StandardPrice
                });
            //filters.ReturnFields.Count.Should().Be(2);
            //filters.ReturnFields.First().Should().Be("name");
            //filters.ReturnFields.ElementAt(1).Should().Be("description");
            filters.Filters.Count.Should().Be(0);
            filters.Limit.Should().BeNull();
            filters.Offset.Should().BeNull();
            var odooClient = new OdooClient(TestConfig);
            var products = await odooClient.GetAsync<ProductProductOdooModel>(filters);

            return null;
        }


    }
}
