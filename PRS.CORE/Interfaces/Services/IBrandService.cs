using PRS.Core.Models.Request;
using PRS.Core.Models.Responce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRS.CORE.Interfaces.Services
{
    public interface IBrandService
    {

        Task<List<BrandResponce>> GetAll();

        Task<BrandResponce?> GetById(Guid id);

        Task<BrandResponce> Create(BrandRequest request);

        Task<BrandResponce> Update(Guid id, BrandRequest request);
		Task<List<BrandResponce>> GetBySearch(string search, int page);

		Task<bool> Delete(Guid id);


    }
}
