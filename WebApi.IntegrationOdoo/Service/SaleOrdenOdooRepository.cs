using FluentAssertions;
using PortaCapena.OdooJsonRpcClient;
using PortaCapena.OdooJsonRpcClient.Shared;
using PortaCapena.OdooJsonRpcClient.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.IntegrationOdoo.IService;

namespace WebApi.IntegrationOdoo.Service
{
    public class SaleOrdenOdooRepository : RequestTestBase, ISaleOrdenOdooRepository
    {
        
        private class SaleOrdenRepository : OdooRepository<SaleOrderOdooModel>
        {
            public SaleOrdenRepository() : base(TestConfig) { }
        }
        public async Task<IEnumerable<SaleOrderOdooModel>> Get_All()
        {
            var repo = new SaleOrdenRepository();

            var result = await repo.Query().ToListAsync();

            result.Error.Should().BeNull();
            result.Succeed.Should().BeTrue();
            //result.Value.Should().NotBeNull().And.NotBeEmpty();

            return result.Value;
        }

        public async Task<SaleOrderOdooModel> Get_For_Id(long Id)
        {
            var repo = new SaleOrdenRepository();

            var result = await repo.Query().ById(Id).FirstOrDefaultAsync();

            result.Error.Should().BeNull();
            result.Succeed.Should().BeTrue();
            result.Value.Should().NotBeNull();

            return result.Value;
        }
    }
}
