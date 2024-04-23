using PRS.Core.Entites;
using PRS.Core.Interfaces.Repository;
using PRS.Core.Models.Request;
using PRS.Core.Models.Responce;
using PRS.DATA;
using PRS.DATA.Repositories;
using Mapster;
using PRS.CORE.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Storage;

namespace PRS.Service.Services
{
    public class CanvasService : ICanvasService
	{

		public readonly ICanvasRepository _canv;
		public readonly AppDbContext _context;
		private readonly IitemsWRepository _items;
		private readonly ISupplierRepository _supplierRepository;
		private readonly IBrandRepository _brand;
		public CanvasService(ICanvasRepository canv, 
			AppDbContext context,
			IitemsWRepository items, 
			ISupplierRepository supplierRepository,
			IBrandRepository brand)
		{
			_context = context;
			_canv = canv;
			_brand = brand;
			_supplierRepository = supplierRepository;
			_items = items;
		}

		public async Task<CanvasResponse> Create(CanvasRequest request)
		{


			var items = await _items.GetByItem(request.ItemName);
			if (items == null) return null;

			var supplier = await _supplierRepository.GetBySupplierNo(request.supno);
			if (supplier == null) return null;

			var brand = await _brand.GetByBrand(request.BrandName);
			if (brand == null) return null;





			var canv = request.Adapt<Canvas>();


			canv.Brand = brand;
			canv.BrandId = brand.Id;
			canv.BrandName = brand.BrandName;
			
			canv.supplierName = supplier.supplierName;
			canv.supno = supplier.supno;
			canv.number1 = supplier.number1;
			canv.keyperson = supplier.keyperson;
			canv.terms = supplier.terms;

			canv.items = items;
			canv.itemsWID = items.Id;
			canv.CategoryCode = items.CategoryCode;
			canv.CatDesc = items.CatDesc;
			canv.EIitem = items.EIitem;
			canv.DNOType = items.DNOType;
			canv.ItemName = items.ItemName;
			canv.DescriptionItem = items.DescriptionItem;
			canv.DNONUMBER = items.DNONUMBER;
			canv.taxrate = items.taxrate;
			canv.UMPC = items.UMPC;
			canv.CostPC = items.CostPC;
			canv.UMCS = items.UMCS;
			canv.CostCS = items.CostCS;
			canv.PCCS = items.PCCS;


			_canv.Add(canv);
			await _canv.SaveChangesAysnc();

			var canvDto = canv.Adapt<CanvasResponse>();
			return canvDto;
		}

		public async Task<bool> Delete(Guid id)
		{
			var canv = await _canv.GetById(id);

			if (canv == null) return false;

			_canv.Delete(canv);

			await _canv.SaveChangesAysnc();

			return true;
		}

		public async Task<List<CanvasResponse>> GetAll()
		{
			var canv = await _canv.GetAll();
			var canvDto = canv.Adapt<List<CanvasResponse>>();

			return canvDto;
		}

		public async Task<CanvasResponse?> GetById(Guid id)
		{
			var canv = await _canv.GetById(id);


			var canvDto = canv?.Adapt<CanvasResponse>();

			return canvDto;
		}


		public async Task<CanvasResponse> Update(Guid id, CanvasRequest request)
		{
			var items = await _items.GetByItem(request.ItemName);
			if (items == null)
			{
				return null;
			}

			var supplier = await _supplierRepository.GetBySupplierNo(request.supno);
			if (supplier == null) return null;

			var brand = await _brand.GetByBrand(request.BrandName);
			if (brand == null) return null;





			var canv = request.Adapt<Canvas>();

			canv.itemsWID = items.Id;
			canv.BrandId = brand.Id;
			canv.supplierName = supplier.supplierName;
			canv.supno = supplier.supno;
			canv.number1 = supplier.number1;
			canv.keyperson = supplier.keyperson;
			canv.terms = supplier.terms;
			canv.BrandName = brand.BrandName;
			canv.ItemName = items.ItemName;
			canv.CatDesc = items.CatDesc;
			canv.CategoryCode = items.CategoryCode;
			canv.EIitem = items.EIitem;
			canv.DNOType = items.DNOType;
			canv.DescriptionItem = items.DescriptionItem;
			canv.DNONUMBER = items.DNONUMBER;
			canv.taxrate = items.taxrate;
			canv.UMCS = items.UMCS;
			canv.CostPC = items.CostPC;
			canv.CostCS = items.CostCS;
			canv.UMPC = items.UMPC;
			canv.PCCS = items.PCCS;


			_canv.Add(canv);
			await _canv.SaveChangesAysnc();

			var canvDto = canv.Adapt<CanvasResponse>();
			return canvDto;
		}

	}
}