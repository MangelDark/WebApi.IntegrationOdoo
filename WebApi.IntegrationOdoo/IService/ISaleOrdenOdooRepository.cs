using PortaCapena.OdooJsonRpcClient.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.IntegrationOdoo.IService
{
    public interface ISaleOrdenOdooRepository
    {
        Task<IEnumerable<SaleOrderOdooModel>> Get_All();
        Task<SaleOrderOdooModel> Get_For_Id(long Id);
    }
}
