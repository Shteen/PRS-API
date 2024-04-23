using PRS.Core.Entites;
using PRS.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRS.Core.Interfaces.Repository
{
	public interface IBrandRepository
	{

			Task<List<Brand>> GetAll();

			Task<Brand?> GetById(Guid id);


			Task<List<Brand>> GetBySearch(string search, int page);
			Task<Brand?> GetByBrand(string BrandName);
			void Add(Brand newbrand);

			void Delete(Brand brand);

			Task<int> SaveChangesAysnc();

		
	}
}