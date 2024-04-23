using PRS.Core.Models.Request;
using PRS.Core.Models.Responce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRS.CORE.Interfaces.Services
{
    public interface IPurchaseOrderService
    {

        Task<List<PurchaseOrderResponce>> GetAll();

        Task<PurchaseOrderResponce?> GetById(Guid Id);

        Task<PurchaseOrderResponce> Create(PurchaseOrderRequest request);

        Task<PurchaseOrderResponce> Update(Guid Id, PurchaseOrderRequest request);

        Task<bool> Delete(Guid Id);


    }
}
