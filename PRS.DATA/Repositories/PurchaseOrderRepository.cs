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
	public class PurchaseOrderRepository : IPurchaseOrderRepository
	{

		private readonly AppDbContext _context;

		public PurchaseOrderRepository(AppDbContext context)
		{
			_context = context;
		}

		public void Add(PurchaseOrder newPurchaseOrder)
		{
			_context.PONum.Add(newPurchaseOrder);
		}

		public void Delete(PurchaseOrder PurchaseOrder)
		{
			_context.PONum.Remove(PurchaseOrder);
		}

		public Task<List<PurchaseOrder>> GetAll()
		{
			return _context.PONum.OrderBy(p => p.PONumber).ToListAsync();
		}

		public Task<PurchaseOrder?> GetByCanvasReff(string CanReffId)
		{
			return _context.PONum.FirstOrDefaultAsync(p => p.PONumber == CanReffId);
		}

		public Task<PurchaseOrder?> GetById(Guid id)
		{
			return _context.PONum.FirstOrDefaultAsync(p => p.Id == id);
		}

		Task<PurchaseOrder?> IPurchaseOrderRepository.GetByPOrefID(string PONumber)
		{
			return _context.PONum.FirstOrDefaultAsync(p => p.PONumber == PONumber);
		}

		public Task<int> SaveChangesAysnc()
		{
			return _context.SaveChangesAsync();
		}
	}
}
