using PRS.Core.Models.Request;
using PRS.Core.Models.Responce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRS.CORE.Interfaces.Services
{
    public interface ICanvasService
    {

        Task<List<CanvasResponse>> GetAll();

        Task<CanvasResponse?> GetById(Guid id);

        Task<CanvasResponse> Create(CanvasRequest request);

        Task<CanvasResponse> Update(Guid id, CanvasRequest request);

        Task<bool> Delete(Guid id);
    }
}
