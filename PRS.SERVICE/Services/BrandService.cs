using Mapster;
using PRS.Core.Entites;
using PRS.Core.Interfaces.Repository;
using PRS.Core.Models.Request;
using PRS.Core.Models.Responce;
using PRS.CORE.Interfaces.Services;
using PRS.DATA;
using PRS.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRS.Service.Services
{
    internal class BrandService : IBrandService
	{
		public readonly IBrandRepository _brnd;
		public readonly AppDbContext _context;
		public BrandService(IBrandRepository brnD, AppDbContext context)
		{
			_context = context;
			_brnd = brnD;
		}

		public async Task<BrandResponce> Create(BrandRequest request)
		{
			var brnD = request.Adapt<Brand>();
			_brnd.Add(brnD);
			await _brnd.SaveChangesAysnc();

			var brnDDto = brnD.Adapt<BrandResponce>();
			return brnDDto;
		}

		public async Task<bool> Delete(Guid id)
		{
			var brnD = await _brnd.GetById(id);
			if (brnD == null) return false;
			_brnd.Delete(brnD);
			await _brnd.SaveChangesAysnc();
			return true;
		}
		public async Task<List<BrandResponce>> GetBySearch(string search, int page)
		{
			int pageSize = 10;
			var employeeDetails = await _brnd.GetBySearch(search, page);
			var skipAmount = (page - 1) * pageSize;
			var paginatedSalaries = employeeDetails.Skip(skipAmount).Take(pageSize).ToList();
			var employeeDetailsDto = paginatedSalaries.Adapt<List<BrandResponce>>();
			return employeeDetailsDto;

		}
		public async Task<List<BrandResponce>> GetAll()
		{
			var brnD = await _brnd.GetAll();
			var brnDDto = brnD.Adapt<List<BrandResponce>>();

			return brnDDto;
		}

		public async Task<BrandResponce?> GetById(Guid id)
		{
			var brnD = await _brnd.GetById(id);
			var brnDDto = brnD?.Adapt<BrandResponce>();
			return brnDDto;
		}



		public async Task<BrandResponce> Update(Guid id, BrandRequest request)
		{
			var brnD = await _brnd.GetById(id);
			if (brnD == null) return null;
			request.Adapt(brnD);
			await _brnd.SaveChangesAysnc();
			return _brnd.Adapt<BrandResponce>();
		}
	}
}
