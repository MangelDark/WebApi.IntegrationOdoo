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
    public class AccountOdooRepository : RequestTestBase,IAccountOdooRepository
    {
        
        private class AccountRepository : OdooRepository<AccountAccountOdooModel>
        {
            public AccountRepository() : base(TestConfig) { }
        }
        public async Task<IEnumerable<AccountAccountOdooModel>> Get_All()
        {
            var repo = new AccountRepository();

            var result = await repo.Query().ToListAsync();

            result.Error.Should().BeNull();
            result.Succeed.Should().BeTrue();
            result.Value.Should().NotBeNull().And.NotBeEmpty();

            return result.Value;
        }

        public async Task<AccountAccountOdooModel> Get_For_Id(long Id)
        {
            var repo = new AccountRepository();

            var result = await repo.Query().ById(Id).FirstOrDefaultAsync();

            result.Error.Should().BeNull();
            result.Succeed.Should().BeTrue();
            result.Value.Should().NotBeNull();

            return result.Value;
        }
    }
}
