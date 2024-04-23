using PRS.Core.Models.Request;
using PRS.Core.Models.Responce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRS.CORE.Interfaces.Services
{
    public interface ISupplierService
    {

        Task<List<SupplierResponce>> GetAll();

        Task<SupplierResponce> Get(int? supno);
        Task<List<SupplierResponce>> GetAllbyPage(int page);

        Task<SupplierResponce> Update(Guid id, SupplierRequest request);

        Task<List<SupplierResponce>> GetBySearch(string search);


    }
}
