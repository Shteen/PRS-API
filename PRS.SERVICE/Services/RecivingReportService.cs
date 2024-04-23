using PRS.Core.Entites;
using PRS.Core.Interfaces.Repository;
using PRS.Core.Models.Request;
using PRS.Core.Models.Responce;
using PRS.DATA;
using PRS.DATA.Repositories;
using Azure.Core;
using Mapster;
using Microsoft.AspNetCore.DataProtection;
using PRS.CORE.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRS.Service.Services
{
    internal class RecivingReportService : IRecivingReportService
	{

		public readonly IRecivingReport _recRepp;
		public readonly AppDbContext _context;
		private readonly IPurchaseOrderRepository _POrep;

		public RecivingReportService(IRecivingReport recRepp, AppDbContext context, IPurchaseOrderRepository POrep)
		{
			_recRepp = recRepp;
			_context = context;
			_POrep = POrep;
		}


		public async Task<RecivingReportResponce> Create(RecivingReportRequest request)
		{
			var POrep = await _POrep.GetByPOrefID(request.PONumber);
			if (POrep == null)
			{
				return null;
			}

		


			var recRepp = request.Adapt<RecivingReport>();


		
			_recRepp.Add(recRepp);
			await _recRepp.SaveChangesAysnc();


			var recReppDto = recRepp.Adapt<RecivingReportResponce>();
			return recReppDto;
		}

		public async Task<bool> Delete(Guid Id)
		{
			var recRepp = await _recRepp.GetById(Id);

			if (recRepp == null) return false;

			_recRepp.Delete(recRepp);

			await _recRepp.SaveChangesAysnc();

			return true;
		}

		public async Task<List<RecivingReportResponce>> GetAll()
		{
			var recRepp = await _recRepp.GetAll();
			var recReppDto = recRepp.Adapt<List<RecivingReportResponce>>();

			return recReppDto; ;
		}

		public Task<RecivingReportResponce?> GetById(Guid Id)
		{
			throw new NotImplementedException();
		}

		public async Task<RecivingReportResponce> Update(Guid Id, RecivingReportRequest request)
		{
			var POrep = await _POrep.GetByPOrefID(request.PONumber);
			if (POrep == null)
			{
				return null;
			}

			var recRepp = request.Adapt<RecivingReport>();

			_recRepp.Add(recRepp);
			await _recRepp.SaveChangesAysnc();


			var recReppDto = recRepp.Adapt<RecivingReportResponce>();
			return recReppDto;
		}
	}
}
