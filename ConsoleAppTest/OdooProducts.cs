using FluentAssertions;
using PortaCapena.OdooJsonRpcClient;
using PortaCapena.OdooJsonRpcClient.Converters;
using PortaCapena.OdooJsonRpcClient.Shared;
using PortaCapena.OdooJsonRpcClient.Shared.Models.Create;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTest
{
   public class OdooProducts : RequestTestBase
    {
        public async Task<object> Can_create_product()
        {
            var odooClient = new OdooClient(TestConfig);

            var model = new OdooCreateProduct()
            {
                Name = "Prod test Kg",
                UomId = 3,
                UomPoId = 3,
            };

            var products = await odooClient.CreateAsync(model);

            products.Error.Should().BeNull();
            products.Succeed.Should().BeTrue();
            return products;
        }
    }
}
