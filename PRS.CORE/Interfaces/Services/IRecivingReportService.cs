using PRS.Core.Models.Request;
using PRS.Core.Models.Responce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRS.CORE.Interfaces.Services
{
    public interface IRecivingReportService
    {
        Task<List<RecivingReportResponce>> GetAll();

        Task<RecivingReportResponce?> GetById(Guid Id);


        Task<RecivingReportResponce> Create(RecivingReportRequest request);

        Task<RecivingReportResponce> Update(Guid Id, RecivingReportRequest request);

        Task<bool> Delete(Guid Id);

    }
}
