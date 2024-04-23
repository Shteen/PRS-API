using PRS.Core.Entites;
using PRS.Core.Interfaces.Repository;
using PRS.Modules;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRS.DATA.Repositories
{
	public class ItemsWRepository : IitemsWRepository
	{

		private readonly AppDbContext _context;

		public ItemsWRepository(AppDbContext context)
		{
			_context = context;
		}

		public void Add(itemsW newitemsW)
		{
			_context.Witems.Add(newitemsW);
		}

		public void Delete(itemsW itemsW)
		{
			_context.Witems.Remove(itemsW);
		}

		public Task<List<itemsW>> GetAll()
		{
			return _context.Witems.OrderBy(p => p.ItemName).ToListAsync();
		}


		public Task<itemsW?> GetByCategoryCode(string CategoryCode)
		{
			return _context.Witems.FirstOrDefaultAsync(p => p.CategoryCode == CategoryCode);
		}

		public Task<itemsW?> GetById(Guid id)
		{
			return _context.Witems.FirstOrDefaultAsync(p => p.Id == id);
		}

		public Task<itemsW?> GetByItem(string ItemName)
		{
			return _context.Witems.FirstOrDefaultAsync(p => p.ItemName == ItemName);
		}

		public Task<List<itemsW>> GetBySearch(string search, int page)
		{
			return _context.Witems.Where(p => p.ItemName.Contains(search)
											).ToListAsync();
		}

		public Task<int> SaveChangesAysnc()
		{
			return _context.SaveChangesAsync();
		}
	}

		
	
}
