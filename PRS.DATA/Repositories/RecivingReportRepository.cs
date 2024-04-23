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
	public class RecivingReportRepository : IRecivingReport
	{
		private readonly AppDbContext _context;

		public RecivingReportRepository(AppDbContext context)
		{
			_context = context;
		}

		public void Add(RecivingReport newRecivingReport)
		{
			_context.RecRep.Add(newRecivingReport);
		}

		public void Delete(RecivingReport RecivingReport)
		{
			_context.RecRep.Remove(RecivingReport);
		}

		public Task<List<RecivingReport>> GetAll()
		{
			return _context.RecRep.OrderBy(p => p.RRnum).ToListAsync();
		}

		public Task<RecivingReport?> GetById(Guid id)
		{
			return _context.RecRep.FirstOrDefaultAsync(p => p.Id == id);
		}

		public Task<RecivingReport?> GetByPOrefID(string POrefID)
		{
			return _context.RecRep.FirstOrDefaultAsync(p => p.PONumber == POrefID);
		}

		public Task<int> SaveChangesAysnc()
		{
			return _context.SaveChangesAsync();
		}
	}
}
