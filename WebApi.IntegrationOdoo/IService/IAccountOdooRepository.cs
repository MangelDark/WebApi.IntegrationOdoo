using PortaCapena.OdooJsonRpcClient.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.IntegrationOdoo.IService
{
    public interface IAccountOdooRepository
    {
        Task<IEnumerable<AccountAccountOdooModel>> Get_All();
        Task<AccountAccountOdooModel> Get_For_Id(long Id);
    }
}
