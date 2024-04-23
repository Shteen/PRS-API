using PRS.Core.Entites;
using PRS.Core.Interfaces.Repository;
using PRS.Core.Models.Request;
using PRS.Core.Models.Responce;
using PRS.DATA;
using Mapster;
using PRS.CORE.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRS.Service.Services
{
    internal class RawMaterialService : IRawMaterialService
	{
		public readonly IRawMaterialRepository _rawMaterial;
		public readonly AppDbContext _context;
		private readonly ICategoryRepository _categoryID;

		public RawMaterialService(IRawMaterialRepository rawMaterial, AppDbContext context, ICategoryRepository categoryi)
		{
			_rawMaterial = rawMaterial;
			_context = context;
			_categoryID = categoryi;
		}

		public async Task<RawMaterialResponce> Create(RawMaterialRequest request)
		{
			var categoryi = await _categoryID.GetByCategoryName(request.CategoryName);
			if (categoryi == null)
			{
				return null;
			}

			var rawMaterial = request.Adapt<RawMaterial>();


			var rawMaterialDto = rawMaterial.Adapt<RawMaterialResponce>();
			return rawMaterialDto;
		}

		public async Task<bool> Delete(Guid id)
		{
			var rawMaterial = await _rawMaterial.GetById(id);

			if (rawMaterial == null) return false;

			_rawMaterial.Delete(rawMaterial);

			await _rawMaterial.SaveChangesAysnc();

			return true;
		}

		public async Task<List<RawMaterialResponce>> GetAll()
		{
			var rawMaterial = await _rawMaterial.GetAll();
			var rawMaterialDto = rawMaterial.Adapt<List<RawMaterialResponce>>();

			return rawMaterialDto;
		}

		public async Task<RawMaterialResponce?> GetById(Guid id)
		{
			throw new NotImplementedException();
		}

		public async Task<RawMaterialResponce> Update(Guid id, RawMaterialRequest request)
		{
			var categoryi = await _categoryID.GetByCategoryName(request.CategoryName);
			if (categoryi == null)
			{
				return null;
			}


			var rawMaterial = await _rawMaterial.GetById(id);
			if (rawMaterial == null) return null;



			return rawMaterial.Adapt<RawMaterialResponce>();
		}
	}
}
