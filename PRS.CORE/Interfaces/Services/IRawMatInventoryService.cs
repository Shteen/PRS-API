using PRS.Core.Models.Request;
using PRS.Core.Models.Responce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRS.CORE.Interfaces.Services
{
    public interface IRawMatInventoryService
    {

        Task<List<RawMatInventoryResponce>> GetAll();

        Task<RawMatInventoryResponce?> GetById(Guid Id);


        Task<RawMatInventoryResponce> Create(RawMatInventoryRequest request);

        Task<RawMatInventoryResponce> Update(Guid Id, RawMatInventoryRequest request);

        Task<bool> Delete(Guid Id);

    }
}
