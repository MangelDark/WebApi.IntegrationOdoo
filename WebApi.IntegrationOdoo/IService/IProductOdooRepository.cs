using PortaCapena.OdooJsonRpcClient.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.IntegrationOdoo.IService
{
    public interface IProductOdooRepository
    {

        Task<IEnumerable<ProductProductOdooModel>> Get_All();
        Task<ProductProductOdooModel> Get_For_Id(long Id);

        
    }
}
