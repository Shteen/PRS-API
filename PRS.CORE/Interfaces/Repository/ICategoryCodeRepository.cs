using PRS.Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace PRS.Core.Interfaces.Repository
{
	public interface ICategoryCodeRepository
	{
		Task<List<CategoryCode>> GetAll();

		Task<CategoryCode?> GetById(Guid id);


		Task<CategoryCode?> GetByCategoryCode(string categoryName);
		void Add(CategoryCode newCategoryCode);

		void Delete(CategoryCode categoryCode);

		Task<int> SaveChangesAysnc();
	}
}
