using PortaCapena.OdooJsonRpcClient.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.IntegrationOdoo.ViewModels;

namespace WebApi.IntegrationOdoo.IService
{
    public interface IResPartnerOdooRepository
    {
        Task<IEnumerable<ResPartnerOdooModel>> Get_All();
        Task<ResPartnerOdooModel> Get_For_Id(long Id);
        Task<bool> Create_ResPartner(ResPartnerViewModel model);
        Task<bool> Update_ResPartner(ResPartnerViewModel model);
    }
}
