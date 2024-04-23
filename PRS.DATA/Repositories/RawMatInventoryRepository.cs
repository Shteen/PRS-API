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
	public class RawMatInventoryRepository : IRawMatInventoryRepository
	{

		private readonly AppDbContext _context;

		public RawMatInventoryRepository(AppDbContext context)
		{
			_context = context;
		}

		public void Add(RawMatInventory newRawMatInventory)
		{
			_context.RMI.Add(newRawMatInventory);
		}

		public void Delete(RawMatInventory RawMatInventory)
		{
			_context.RMI.Remove(RawMatInventory);
		}

		public Task<List<RawMatInventory>> GetAll()
		{
			return _context.RMI.OrderBy(p => p.RawMatInvNumber).ToListAsync();
		}

		public Task<RawMatInventory?> GetByCanvasReff(string CanReffId)
		{
			return _context.RMI.FirstOrDefaultAsync(p => p.RawMatInvNumber == CanReffId);
		}

		public Task<RawMatInventory?> GetById(Guid id)
		{
			return _context.RMI.FirstOrDefaultAsync(p => p.Id == id);
		}

		public Task<int> SaveChangesAysnc()
		{
			return _context.SaveChangesAsync();
		}
	}
}
