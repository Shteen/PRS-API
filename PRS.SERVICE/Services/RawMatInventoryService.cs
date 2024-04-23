using PRS.Core.Entites;
using PRS.Core.Interfaces.Repository;
using PRS.Core.Models.Request;
using PRS.Core.Models.Responce;
using PRS.DATA;
using Mapster;
using Microsoft.EntityFrameworkCore;
using PRS.CORE.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRS.Service.Services
{
    public class RawMatInventoryService : IRawMatInventoryService
	{

		public readonly IRawMatInventoryRepository _rawmi;
		public readonly AppDbContext _context;
		private readonly ICanvasRepository _canvrep;

		public RawMatInventoryService(IRawMatInventoryRepository rawMI, AppDbContext context, ICanvasRepository canvREP)
		{
			_rawmi = rawMI;
			_context = context;
			_canvrep = canvREP;
		}

		public async Task<RawMatInventoryResponce> Create(RawMatInventoryRequest request)
		{
			var canvREP = await _canvrep.GetByCanvasReff(request.CVSNO);
			if (canvREP == null)
			{
				return null;
			}

			var rawMI = request.Adapt<RawMatInventory>();

			_rawmi.Add(rawMI);
			await _rawmi.SaveChangesAysnc();


			var rawMIDto = rawMI.Adapt<RawMatInventoryResponce>();
			return rawMIDto;
		}

		public async Task<bool> Delete(Guid Id)
		{
			var rawMIDto = await _rawmi.GetById(Id);

			if (rawMIDto == null) return false;

			_rawmi.Delete(rawMIDto);

			await _rawmi.SaveChangesAysnc();

			return true;
		}

		public async Task<List<RawMatInventoryResponce>> GetAll()
		{
			var rawMI = await _rawmi.GetAll();
			var rawMIDto = rawMI.Adapt<List<RawMatInventoryResponce>>();

			return rawMIDto;
		}

		public Task<RawMatInventoryResponce?> GetById(Guid Id)
		{
			throw new NotImplementedException();
		}

		public async Task<RawMatInventoryResponce> Update(Guid Id, RawMatInventoryRequest request)
		{
			var canvREP = await _canvrep.GetByCanvasReff(request.CVSNO);
			if (canvREP == null)
			{
				return null;
			}

			var rawMI = request.Adapt<RawMatInventory>();

			_rawmi.Add(rawMI);
			await _rawmi.SaveChangesAysnc();


			var rawMIDto = rawMI.Adapt<RawMatInventoryResponce>();
			return rawMIDto;
		}
	}
}
