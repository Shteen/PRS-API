using PRS.Core.Entites;
using PRS.Core.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRS.Modules;

namespace PRS.DATA.Repositories
{
	public class BrandRepository : IBrandRepository
	{

		private readonly AppDbContext _context;

		public BrandRepository(AppDbContext context)
		{
			_context = context;
		}

		public void Add(Brand newbrand)
		{
			_context.BRND.Add(newbrand);
		}

		public void Delete(Brand brand)
		{
			_context.BRND.Remove(brand);
		}

		public Task<List<Brand>> GetAll()
		{
			return _context.BRND.OrderBy(p => p.BrandNumber).ToListAsync();
		}

		public Task<List<Brand>> GetBySearch(string search, int page)
		{
			return _context.BRND.Where(p => p.BrandName.Contains(search)
											).ToListAsync();
		}
		public Task<Brand?> GetByBrand(string BrandName)
		{
			return _context.BRND.FirstOrDefaultAsync(p => p.BrandName == BrandName);
		}

			public Task<Brand?> GetById(Guid id)
		{
			return _context.BRND.FirstOrDefaultAsync(p => p.Id == id);
		}

		public Task<int> SaveChangesAysnc()
		{
			return _context.SaveChangesAsync();
		}
	}
}
