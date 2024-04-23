using PRS.Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRS.Core.Interfaces.Repository
{
	public interface ISupplierRepository
	{

		Task<List<Supplier>> GetAll();

		Task<Supplier?> GetBySupplierNo(int? supno);

		Task<List<Supplier>> GetBySearch(string search);
		Task<Supplier?> GetById(Guid id);
		Task<int> SaveChangesAysnc();


	}
}
