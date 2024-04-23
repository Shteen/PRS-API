using PRS.Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRS.Core.Interfaces.Repository
{
	public interface IRawMaterialRepository
	{
		Task<List<RawMaterial>> GetAll();

		Task<RawMaterial?> GetById(Guid id);



		Task<List<RawMaterial>> GetCategoryByCategoryCode(Guid categoryCodeId);
		Task<RawMaterial?> GetByRawMaterialName(string RawMaterialName);

		void Add(RawMaterial newRawMaterial);

		void Delete(RawMaterial RawMaterial);

		Task<int> SaveChangesAysnc();
		Task GetByRawMaterial(object RawMaterialName);
		Task GetByRawMaterialRepository(string RawMaterialName);
	}

}