using PRS.Core.Models.Request;
using PRS.Core.Models.Responce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRS.CORE.Interfaces.Services
{
    public interface ICategoryService
    {
        Task<List<CategoryResponse>> GetAll();

        Task<CategoryResponse?> GetById(Guid id);


        Task<CategoryResponse> Create(CategoryRequest request);

        Task<CategoryResponse> Update(Guid id, CategoryRequest request);

        Task<bool> Delete(Guid id);
    }
}
