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
	public class SupplierRepository : ISupplierRepository
	{

		private readonly SupplierConnection _context;

		public SupplierRepository(SupplierConnection context)
		{
			_context = context;
		}


		public Task<List<Supplier>> GetAll()
		{
			return _context.SUPPLIER.OrderBy(p => p.supplierName).ToListAsync();
		}

		public Task<Supplier?> GetBySupplierNo(int? supno)
		{
			return _context.SUPPLIER.FirstOrDefaultAsync(p => p.supno == supno);
		}

		public Task<List<Supplier>> GetBySearch(string search)
		{
			return _context.SUPPLIER.Where(p => p.supplierName.Contains(search)
											).ToListAsync();
		}

		public Task<Supplier?> GetById(Guid id)
		{
			return _context.SUPPLIER.FirstOrDefaultAsync(p => p.Id == id);
		}

		public Task<int> SaveChangesAysnc()
		{
			return _context.SaveChangesAsync();
		}

	}
}