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
	public class CanvasRepository : ICanvasRepository
	{
		private readonly AppDbContext _context;

		public CanvasRepository(AppDbContext context)
		{
			_context = context;
		}

		public void Add(Canvas newCanvas)
		{
			_context.CanV.Add(newCanvas);
		}

		public void Delete(Canvas Canvas)
		{
			_context.CanV.Remove(Canvas);
		}

		public Task<List<Canvas>> GetAll()
		{
			return _context.CanV.OrderBy(p => p.CVSNO).ToListAsync();
		}

		public Task<Canvas?> GetBrand(string BrandName)
		{
			return _context.CanV.FirstOrDefaultAsync(p => p.BrandName == BrandName);
		}

		public Task<Canvas?> GetById(Guid id)
		{
			return _context.CanV.FirstOrDefaultAsync(p => p.Id == id);
		}

		public Task<Canvas?> GetItem(string ItemName)
		{
			return _context.CanV.FirstOrDefaultAsync(p => p.ItemName == ItemName);
		}

		public Task<Canvas?> GetSupplier(int supno)
		{
			return _context.CanV.FirstOrDefaultAsync(p => p.supno == supno);
		}

		public Task<int> SaveChangesAysnc()
		{
			return _context.SaveChangesAsync();
		}

		Task<Canvas?> ICanvasRepository.GetByCanvasReff(string cVSNO)
		{
			return _context.CanV.FirstOrDefaultAsync(p => p.CVSNO == cVSNO);
		}
	}
}
