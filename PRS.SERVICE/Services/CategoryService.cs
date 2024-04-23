using PRS.Core.Entites;
using PRS.Core.Interfaces.Repository;
using PRS.Core.Models.Request;
using PRS.Core.Models.Responce;
using PRS.DATA;
using Mapster;
using PRS.CORE.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRS.Service.Services
{
    public class CategoryService : ICategoryService
	{
		public readonly ICategoryRepository _category;
		public readonly AppDbContext _context;
		private readonly ICategoryCodeRepository _categorycode;

		public CategoryService(ICategoryRepository category, AppDbContext context, ICategoryCodeRepository categoryCode)
		{
			_category = category;
			_context = context;
			_categorycode = categoryCode;
		}
		public async Task<CategoryResponse> Create(CategoryRequest request)
		{
			var categoryCode = await _categorycode.GetByCategoryCode(request.CategoryName);
			if(categoryCode == null)
			{
				return null;
			}

			var category = request.Adapt<Category>();

			

			category.CategoryCodeId= categoryCode.Id;
			category.CategoryCode = categoryCode.CategCode;
			category.DNOTYPE = categoryCode.DNOTYPE;
			_category.Add(category);
			await _category.SaveChangesAysnc();

			var categoryDto = category.Adapt<CategoryResponse>();
			return categoryDto;

		}

		public async Task<bool> Delete(Guid id)
		{
			var category = await _category.GetById(id);
			
			if (category == null) return false;

			_category.Delete(category);

			await _category.SaveChangesAysnc();

			return true;
		}

		public async Task<List<CategoryResponse>> GetAll()
		{
			var category = await _category.GetAll();
			var categoryDto = category.Adapt<List<CategoryResponse>>();

			return categoryDto;
		}

		public async Task<CategoryResponse?> GetById(Guid id)
		{
			var category = await _category.GetById(id);


			var categoryDto = category?.Adapt<CategoryResponse>();

			return categoryDto;
		}


		public async Task<CategoryResponse> Update(Guid id, CategoryRequest request)
		{
			var categoryCode = await _categorycode.GetByCategoryCode(request.CategoryName);
			if (categoryCode == null)
			{
				return null;
			}

			var category = await _category.GetById(id);
			if (category == null) return null;


			category.CategoryCodeId = categoryCode.Id;
			category.CategoryCode = categoryCode.CategCode;
			category.DNOTYPE = categoryCode.DNOTYPE;
			_category.Add(category);
			await _category.SaveChangesAysnc();

			return category.Adapt<CategoryResponse>();
		}
	}
}
