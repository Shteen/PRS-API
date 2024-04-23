using PRS.Core.Entites;
using PRS.Core.Interfaces.Repository;
using PRS.Core.Models.Request;
using PRS.Core.Models.Responce;
using PRS.DATA;
using Mapster;
using PRS.CORE.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRS.Service.Services
{
    public class CategoryCodeService : ICategoryCodeService		
	{
		public readonly ICategoryCodeRepository _categoryCode;
		public readonly AppDbContext _context;
		public CategoryCodeService(ICategoryCodeRepository categoryCode, AppDbContext context)
		{
			_context = context;
			_categoryCode = categoryCode;
		}

		public async Task<CategoryCodeResponse> Create(CategoryCodeRequest request)
		{
			var categoryCode = request.Adapt<CategoryCode>();

			_categoryCode.Add(categoryCode);
			await _categoryCode.SaveChangesAysnc();


			var categoryCodeDto = categoryCode.Adapt<CategoryCodeResponse>();

			return categoryCodeDto;
		}

		public async Task<bool> Delete(Guid id)
		{
			var categoryCode = await _categoryCode.GetById(id);

			if (categoryCode == null) return false;

			_categoryCode.Delete(categoryCode);

			await _categoryCode.SaveChangesAysnc();

			return true;
		}

		public async Task<List<CategoryCodeResponse>> GetAll()
		{
			var categoryCode = await _categoryCode.GetAll();
			var categoryCodeDto = categoryCode.Adapt<List<CategoryCodeResponse>>();
			
			return categoryCodeDto;
		}

		public async Task<CategoryCodeResponse?> GetById(Guid id)
		{
			var categoryCode = await _categoryCode.GetById(id);


			var categoryCodeDto = categoryCode?.Adapt<CategoryCodeResponse>();

			return categoryCodeDto;
		}

		

		public async Task<CategoryCodeResponse> Update(Guid id, CategoryCodeRequest request)
		{
			var categoryCode = await _categoryCode.GetById(id);


			if (categoryCode == null) return null;



			request.Adapt(categoryCode);

			await _categoryCode.SaveChangesAysnc();

			return _categoryCode.Adapt<CategoryCodeResponse>();
		}

	}
}
