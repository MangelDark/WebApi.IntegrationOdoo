using PortaCapena.OdooJsonRpcClient.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.IntegrationOdoo.IService
{
    public interface ICustomerOdooRepository
    {
        Task<IEnumerable<CustomersCustomerOdooModel>> Get_All();
        Task<CustomersCustomerOdooModel> Get_For_Id(long Id);
    }
}
