using PRS.Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace PRS.Core.Interfaces.Repository
{
	public interface ICategoryRepository
	{
		Task<List<Category>> GetAll();

		Task<Category?> GetById(Guid id);


		
		Task<List<Category>> GetCategoryByCategoryCode(Guid categoryCodeId);
		Task<Category?> GetByCategoryName(string CategoryCode);

		void Add(Category newCategory);

		void Delete(Category category);

		Task<int> SaveChangesAysnc();
		Task GetByCategory(object CategoryCode);
		Task GetByCategoryRepository(string CategoryCode);
	}
}
