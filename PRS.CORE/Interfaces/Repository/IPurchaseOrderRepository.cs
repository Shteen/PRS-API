using PRS.Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRS.Core.Interfaces.Repository
{
	public interface IPurchaseOrderRepository
	{

		Task<List<PurchaseOrder>> GetAll();
		Task<PurchaseOrder?> GetById(Guid id);
		Task<PurchaseOrder?> GetByCanvasReff(string CanReffId);
		Task<PurchaseOrder?> GetByPOrefID(string PONumber);
		void Add(PurchaseOrder newPurchaseOrder);
		void Delete(PurchaseOrder PurchaseOrder);
		Task<int> SaveChangesAysnc();
	}

}

