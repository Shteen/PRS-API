using PRS.Core.Entites;
using PRS.Core.Interfaces.Repository;
using PRS.Core.Models.Request;
using PRS.Core.Models.Responce;
using PRS.DATA;
using PRS.DATA.Repositories;
using PRS.Modules;
using Mapster;
using PRS.CORE.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRS.Service.Services
{
    public class ItemsWService : IitemsWService
	{

		public readonly IitemsWRepository _itemsW;
		//public readonly AppDbContext _context;
		private readonly IBrandRepository _brand;
		private readonly ICategoryRepository _category;

		public ItemsWService(IitemsWRepository Itemsw, AppDbContext context, IBrandRepository brand, ICategoryRepository category)
		{
			_itemsW = Itemsw;
			//_context = context;
			_brand = brand;
			_category = category;
		}
		public async Task<ItemsWResponce> Create(ItemsWRequest request)
		{
			var category = await _category.GetByCategoryName(request.CategoryCode);
			if (category == null)
			{
				return null;
			}


			var Itemsw = request.Adapt<itemsW>();

			Itemsw.category = category;
			Itemsw.CategoryCode = category.CategoryCode;
			Itemsw.CatDesc = category.CatDesc;
			Itemsw.DNOType = category.DNOTYPE;
			Itemsw.categoryID = category.id;
			
			_itemsW.Add(Itemsw);
			await _itemsW.SaveChangesAysnc();

			var itemswDto = Itemsw.Adapt<ItemsWResponce>();
			return itemswDto;
		}

		public async Task<bool> Delete(Guid id)
		{
			var Itemsw = await _itemsW.GetById(id);

			if (Itemsw == null) return false;

			_itemsW.Delete(Itemsw);

			await _itemsW.SaveChangesAysnc();

			return true;
		}

		public async Task<List<ItemsWResponce>> GetAll()
		{
			var Itemsw = await _itemsW.GetAll();
			var itemswDto = Itemsw.Adapt<List<ItemsWResponce>>();

			return itemswDto;
		}

		public async Task<List<ItemsWResponce>> GetAllbyPage(int page)
		{
			int pageSize = 10; // Set the default page size
			var salaries = await _itemsW.GetAll();
			var skipAmount = (page - 1) * pageSize; // Adjusted to start from page 1
			var paginatedSalaries = salaries.Skip(skipAmount).Take(pageSize).ToList();
			var salaryDto = paginatedSalaries.Adapt<List<ItemsWResponce>>();
			return salaryDto;
		}

		public async Task<ItemsWResponce?> GetById(Guid id)
		{
			var Itemsw = await _itemsW.GetById(id);


			var itemswDto = Itemsw?.Adapt<ItemsWResponce>();

			return itemswDto;
		}

		public async Task<List<ItemsWResponce>> GetBySearch(string search, int page)
		{
			int pageSize = 10;
			var employeeDetails = await _itemsW.GetBySearch(search, page);
			var skipAmount = (page - 1) * pageSize;
			var paginatedSalaries = employeeDetails.Skip(skipAmount).Take(pageSize).ToList();
			var employeeDetailsDto = paginatedSalaries.Adapt<List<ItemsWResponce>>();
			return employeeDetailsDto;

		}

		public async Task<ItemsWResponce> Update(Guid id, ItemsWRequest request)
		{
			var category = await _category.GetByCategoryName(request.CategoryCode);
			if (category == null)
			{
				return null;
			}


			var Itemsw = request.Adapt<itemsW>();


			Itemsw.CategoryCode = category.CategoryCode;
			Itemsw.CatDesc = category.CatDesc;
			Itemsw.DNOType = category.DNOTYPE;
			Itemsw.categoryID = category.id;
			_itemsW.Add(Itemsw);
			await _itemsW.SaveChangesAysnc();

			var itemswDto = Itemsw.Adapt<ItemsWResponce>();
			return itemswDto;
		}
	}
}
