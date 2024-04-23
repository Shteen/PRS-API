using PRS.Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRS.Core.Interfaces.Repository
{
	public interface IRawMatInventoryRepository
	{

		Task<List<RawMatInventory>> GetAll();

		Task<RawMatInventory?> GetById(Guid id);


		Task<RawMatInventory?> GetByCanvasReff(string CanReffId);

		void Add(RawMatInventory newRawMatInventory);

		void Delete(RawMatInventory  RawMatInventory);

		Task<int> SaveChangesAysnc();
	}


}

