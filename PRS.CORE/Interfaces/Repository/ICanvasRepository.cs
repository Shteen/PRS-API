using PRS.Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRS.Core.Interfaces.Repository
{
	public interface ICanvasRepository
	{

		Task<List<Canvas>> GetAll();
		Task<Canvas?> GetById(Guid id);
		Task<Canvas?> GetSupplier(int supno);
		Task<Canvas?> GetItem(string ItemName);
		Task<Canvas?> GetBrand(string BrandName);
		Task<Canvas?> GetByCanvasReff(string CVSNO);

		void Add(Canvas newCanvas);
		void Delete(Canvas Canvas);
		Task<int> SaveChangesAysnc();
	}
}
