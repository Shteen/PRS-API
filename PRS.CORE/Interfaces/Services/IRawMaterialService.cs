using PRS.Core.Models.Request;
using PRS.Core.Models.Responce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRS.CORE.Interfaces.Services
{
    public interface IRawMaterialService
    {
        Task<List<RawMaterialResponce>> GetAll();

        Task<RawMaterialResponce?> GetById(Guid id);


        Task<RawMaterialResponce> Create(RawMaterialRequest request);

        Task<RawMaterialResponce> Update(Guid id, RawMaterialRequest request);

        Task<bool> Delete(Guid id);

    }
}
