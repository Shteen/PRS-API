using PRS.Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRS.Core.Interfaces.Repository
{
	public interface IRecivingReport
	{

		Task<List<RecivingReport>> GetAll();

		Task<RecivingReport?> GetById(Guid id);


		Task<RecivingReport?> GetByPOrefID(string POrefID);

		void Add(RecivingReport newRecivingReport);

		void Delete(RecivingReport RecivingReport);

		Task<int> SaveChangesAysnc();

	}
}
