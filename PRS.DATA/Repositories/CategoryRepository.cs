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

	public class CategoryRepository : ICategoryRepository
    {
		private readonly AppDbContext _context;

		public CategoryRepository(AppDbContext context)
		{
			_context = context;
		}

		public void Add(Category newCategory)
		{
			_context.categories.Add(newCategory);
		}

		public void Delete(Category category)
		{
			_context.categories.Remove(category);
		}

		public Task<List<Category>> GetAll()
		{
			return _context.categories.OrderBy(p => p.CategoryName).ToListAsync();
		}

		public Task<Category?> GetById(Guid id)
		{
			return _context.categories.FirstOrDefaultAsync(p => p.id == id);
		}

		

		public Task<int> SaveChangesAysnc()
		{
			return _context.SaveChangesAsync();
		}
		public Task<List<Category>> GetCategoryByCategoryCode(Guid categoryCodeId)
		{
			return _context.categories.Where(p => p.CategoryCodeId == categoryCodeId).ToListAsync();
		}


		Task ICategoryRepository.GetByCategory(object categoryName)
		{
			throw new NotImplementedException();
		}

		Task ICategoryRepository.GetByCategoryRepository(string categoryName)
		{
			throw new NotImplementedException();
		}

		Task<Category?> ICategoryRepository.GetByCategoryName(string categoryName)
		{
			return _context.categories.FirstOrDefaultAsync(p => p.CategoryCode == categoryName);
		}
	}
}
