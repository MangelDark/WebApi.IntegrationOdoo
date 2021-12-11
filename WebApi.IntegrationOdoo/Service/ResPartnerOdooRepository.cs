using FluentAssertions;
using PortaCapena.OdooJsonRpcClient;
using PortaCapena.OdooJsonRpcClient.Extensions;
using PortaCapena.OdooJsonRpcClient.Models;
using PortaCapena.OdooJsonRpcClient.Shared;
using PortaCapena.OdooJsonRpcClient.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.IntegrationOdoo.IService;
using WebApi.IntegrationOdoo.ViewModels;

namespace WebApi.IntegrationOdoo.Service
{
    public class ResPartnerOdooRepository : RequestTestBase, IResPartnerOdooRepository
    {
        
        private class ResPartnerRepository : OdooRepository<ResPartnerOdooModel>
        {
            public ResPartnerRepository() : base(TestConfig) { }
        }
        public async Task<IEnumerable<ResPartnerOdooModel>> Get_All()
        {
            var repo = new ResPartnerRepository();

            var result = await repo.Query().ToListAsync();

            result.Error.Should().BeNull();
            result.Succeed.Should().BeTrue();
            result.Value.Should().NotBeNull().And.NotBeEmpty();

            return result.Value;
        }
    
        public async Task<ResPartnerOdooModel> Get_For_Id(long Id)
        {
            var repo = new ResPartnerRepository();

            var result = await repo.Query().ById(Id).FirstOrDefaultAsync();

            result.Error.Should().BeNull();
            result.Succeed.Should().BeTrue();
            result.Value.Should().NotBeNull();

            return result.Value;
        }



        public async Task<bool> Create_ResPartner(ResPartnerViewModel model)
        {          
            var request = OdooDictionaryModel.Create(() => new ResPartnerOdooModel()
            {
                Name = model.Name,
                Title = model.Title,
                Website = model.Website,
                Comment = model.Comment,
                CreditLimit = model.CreditLimit,
                Email = model.Email,
                Phone = model.Phone,
                Mobile = model.Mobile,
                City = model.City,
                Zip = model.Zip,
                Vat = model.Vat,
                Street = model.Street,
            });

            var odooClient = new OdooClient(TestConfig);

            var customer = await odooClient.CreateAsync(request);

            customer.Succeed.Should().BeTrue();
            if (customer.Succeed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public async Task<bool> Update_ResPartner(ResPartnerViewModel model)
        {
            var request = OdooDictionaryModel.Create(() => new ResPartnerOdooModel()
            {
                Name = model.Name,
                Title = model.Title,
                Website = model.Website,
                Comment = model.Comment,
                CreditLimit = model.CreditLimit,
                Email = model.Email,
                Phone = model.Phone,
                Mobile = model.Mobile,
                City = model.City,
                Zip = model.Zip,
                Vat = model.Vat,
                Street = model.Street,
            });

            var odooClient = new OdooClient(TestConfig);

            var customer = await odooClient.UpdateAsync(request,model.Id);

            customer.Succeed.Should().BeTrue();
            if (customer.Succeed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public async Task<bool> Delete_ResPartner(ResPartnerViewModel model)
        {

            var request = new ResPartnerOdooModel()
            {
                Id = model.Id       
            };

            var odooClient = new OdooClient(TestConfig);

            var customer = await odooClient.DeleteAsync(request.OdooTableName(),request.Id);

            customer.Succeed.Should().BeTrue();
            customer.Error.Should().BeNull();
            if (customer.Succeed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
