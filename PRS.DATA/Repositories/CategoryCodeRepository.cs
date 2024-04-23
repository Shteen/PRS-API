using PRS.Core.Entites;
using PRS.Core.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRS.DATA.Repositories
{
	public class CategoryCodeRepository : ICategoryCodeRepository
	{
		private readonly AppDbContext _context;

		public CategoryCodeRepository(AppDbContext context)
		{
			_context = context;
		}
		public void Add(CategoryCode newCategoryCode)
		{
			_context.CategoryCodes.Add(newCategoryCode);
		}

		public void Delete(CategoryCode categoryCode)
		{
			_context.CategoryCodes.Remove(categoryCode);
		}

		public Task<List<CategoryCode>> GetAll()
		{
			return _context.CategoryCodes.OrderBy(p => p.CategoryName).ToListAsync();
		}

		public Task<CategoryCode?> GetByCategoryCode(string categoryName)
		{
			return _context.CategoryCodes.FirstOrDefaultAsync(p => p.CategoryName == categoryName);
		}

		public Task<CategoryCode?> GetById(Guid id)
		{
			return _context.CategoryCodes.FirstOrDefaultAsync(p => p.Id == id);
		}

	

		public Task<int> SaveChangesAysnc()
		{
			return _context.SaveChangesAsync();
		}
	}
}
