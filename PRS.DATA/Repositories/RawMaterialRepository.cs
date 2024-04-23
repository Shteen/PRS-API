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
	public class RawMaterialRepository : IRawMaterialRepository
	{

		private readonly AppDbContext _context;

		public RawMaterialRepository(AppDbContext context)
		{
			_context = context;
		}

		public void Add(RawMaterial newRawMaterial)
		{
			_context.RawMaterials.Add(newRawMaterial);
		}

		public void Delete(RawMaterial RawMaterial)
		{
			_context.RawMaterials.Remove(RawMaterial);
		}

		public Task<List<RawMaterial>> GetAll()
		{
			return _context.RawMaterials.OrderBy(p => p.RawMaterialName).ToListAsync();
		}

		public Task<RawMaterial?> GetById(Guid id)
		{
			return _context.RawMaterials.FirstOrDefaultAsync(p => p.id == id);
		}

		public Task GetByRawMaterial(object RawMaterialName)
		{
			throw new NotImplementedException();
		}

		public Task<RawMaterial?> GetByRawMaterialName(string RawMaterialName)
		{
			return _context.RawMaterials.FirstOrDefaultAsync(p => p.RawMaterialName == RawMaterialName);
		}

		public Task GetByRawMaterialRepository(string RawMaterialName)
		{
			throw new NotImplementedException();
		}

		public Task<List<RawMaterial>> GetCategoryByCategoryCode(Guid categoryCodeId)
		{
			throw new NotImplementedException();
		}

		public Task<int> SaveChangesAysnc()
		{
			return _context.SaveChangesAsync();
		}
	}
	}
