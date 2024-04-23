using PRS.Core.Entites;
using PRS.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRS.Core.Interfaces.Repository
{
	public interface IitemsWRepository
	{
		Task<List<itemsW>> GetAll();

		Task<itemsW?> GetById(Guid id);

		Task<itemsW?> GetByCategoryCode(string CategoryCode);
		Task<itemsW?> GetByItem(string ItemName);
		void Add(itemsW newitemsW);
		Task<List<itemsW>> GetBySearch(string search, int page);
		void Delete(itemsW itemsW);

		Task<int> SaveChangesAysnc();
	}
}
