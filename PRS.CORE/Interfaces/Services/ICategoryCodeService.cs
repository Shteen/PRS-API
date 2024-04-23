using PRS.Core.Models.Request;
using PRS.Core.Models.Responce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRS.CORE.Interfaces.Services
{
    public interface ICategoryCodeService
    {
        Task<List<CategoryCodeResponse>> GetAll();

        Task<CategoryCodeResponse?> GetById(Guid id);

        Task<CategoryCodeResponse> Create(CategoryCodeRequest request);

        Task<CategoryCodeResponse> Update(Guid id, CategoryCodeRequest request);

        Task<bool> Delete(Guid id);

    }
}
