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
    internal class PurchaseOrderService : IPurchaseOrderService
	{

		public readonly IPurchaseOrderRepository _purchaseOrder;
		public readonly AppDbContext _context;
		private readonly ICanvasRepository _canvasI;

		public PurchaseOrderService(IPurchaseOrderRepository purchaseOrder, AppDbContext context, ICanvasRepository canvasI)
		{
			_purchaseOrder = purchaseOrder;
			_context = context;
			_canvasI = canvasI;
		}
		public async Task<PurchaseOrderResponce> Create(PurchaseOrderRequest request)
		{
			var canvasI = await _canvasI.GetByCanvasReff(request.CVSNO);
			if (canvasI == null)
			{
				return null;
			}

			var purchaseOrder = request.Adapt<PurchaseOrder>();

			purchaseOrder.CanReffId = canvasI.Id;
			purchaseOrder.CanReff = canvasI;
			purchaseOrder.CVSNO = canvasI.CVSNO;
			purchaseOrder.Factory = canvasI.Factory;
			purchaseOrder.DateOrder = canvasI.DateOrder;
			purchaseOrder.Company = canvasI.Company;
			purchaseOrder.Department = canvasI.Department;
			purchaseOrder.ReqDescript = canvasI.ReqDescript;
			purchaseOrder.ReqBy = canvasI.ReqBy;
			purchaseOrder.Type = canvasI.Type;
			purchaseOrder.ppe = canvasI.ppe;
			purchaseOrder.Remarks = canvasI.Remarks;
			purchaseOrder.EI = canvasI.EI;
			purchaseOrder.supplierName = canvasI.supplierName;
			purchaseOrder.supno = canvasI.supno;
			purchaseOrder.number1 = canvasI.number1;
			purchaseOrder.keyperson = canvasI.keyperson;
			purchaseOrder.terms = canvasI.terms;
			purchaseOrder.CategoryCode = canvasI.CategoryCode;
			purchaseOrder.CatDesc = canvasI.CatDesc;
			purchaseOrder.EIitem = canvasI.EIitem;
			purchaseOrder.DNOType = canvasI.DNOType;
			purchaseOrder.ItemName = canvasI.ItemName;
			purchaseOrder.DescriptionItem = canvasI.DescriptionItem;
			purchaseOrder.DNONUMBER = canvasI.DNONUMBER;
			purchaseOrder.taxrate = canvasI.taxrate;
			purchaseOrder.UMPC = canvasI.UMPC;
			purchaseOrder.CostPC = canvasI.CostPC;
			purchaseOrder.UMCS = canvasI.UMCS;
			purchaseOrder.CostCS = canvasI.CostCS;
			purchaseOrder.PCCS = canvasI.PCCS;
			purchaseOrder.QTY = canvasI.QTY;
			purchaseOrder.Total = canvasI.Total;
			purchaseOrder.Status = canvasI.Status;
			purchaseOrder.BrandName = canvasI.BrandName;

			_purchaseOrder.Add(purchaseOrder);
			await _purchaseOrder.SaveChangesAysnc();


			var rawMaterialDto = purchaseOrder.Adapt<PurchaseOrderResponce>();
			return rawMaterialDto;
		}

		public async Task<bool> Delete(Guid Id)
		{
			var purchaseOrder = await _purchaseOrder.GetById(Id);

			if (purchaseOrder == null) return false;

			_purchaseOrder.Delete(purchaseOrder);

			await _purchaseOrder.SaveChangesAysnc();

			return true;
		}

		public async Task<List<PurchaseOrderResponce>> GetAll()
		{
			var purchaseOrder = await _purchaseOrder.GetAll();
			var purchaseOrderDto = purchaseOrder.Adapt<List<PurchaseOrderResponce>>();

			return purchaseOrderDto;
		}

		public async Task<PurchaseOrderResponce?> GetById(Guid Id)
		{
			var purchaseOrder = await _purchaseOrder.GetById(Id);


			var purchaseOrderDto = purchaseOrder?.Adapt<PurchaseOrderResponce>();

			return purchaseOrderDto;
		}

		public async Task<PurchaseOrderResponce> Update(Guid Id, PurchaseOrderRequest request)
		{
			var canvasI = await _canvasI.GetByCanvasReff(request.CVSNO);
			if (canvasI == null)
			{
				return null;
			}

			var purchaseOrder = request.Adapt<PurchaseOrder>();

			purchaseOrder.CanReffId = canvasI.Id;
			purchaseOrder.CanReff = canvasI;
			purchaseOrder.CVSNO = canvasI.CVSNO;
			purchaseOrder.Factory = canvasI.Factory;
			purchaseOrder.DateOrder = canvasI.DateOrder;
			purchaseOrder.Company = canvasI.Company;
			purchaseOrder.Department = canvasI.Department;
			purchaseOrder.ReqDescript = canvasI.ReqDescript;
			purchaseOrder.ReqBy = canvasI.ReqBy;
			purchaseOrder.Type = canvasI.Type;
			purchaseOrder.ppe = canvasI.ppe;
			purchaseOrder.Remarks = canvasI.Remarks;
			purchaseOrder.EI = canvasI.EI;
			purchaseOrder.supplierName = canvasI.supplierName;
			purchaseOrder.supno = canvasI.supno;
			purchaseOrder.number1 = canvasI.number1;
			purchaseOrder.keyperson = canvasI.keyperson;
			purchaseOrder.terms = canvasI.terms;
			purchaseOrder.CategoryCode = canvasI.CategoryCode;
			purchaseOrder.CatDesc = canvasI.CatDesc;
			purchaseOrder.EIitem = canvasI.EIitem;
			purchaseOrder.DNOType = canvasI.DNOType;
			purchaseOrder.ItemName = canvasI.ItemName;
			purchaseOrder.DescriptionItem = canvasI.DescriptionItem;
			purchaseOrder.DNONUMBER = canvasI.DNONUMBER;
			purchaseOrder.taxrate = canvasI.taxrate;
			purchaseOrder.UMPC = canvasI.UMPC;
			purchaseOrder.CostPC = canvasI.CostPC;
			purchaseOrder.UMCS = canvasI.UMCS;
			purchaseOrder.CostCS = canvasI.CostCS;
			purchaseOrder.PCCS = canvasI.PCCS;
			purchaseOrder.QTY = canvasI.QTY;
			purchaseOrder.Total = canvasI.Total;
			purchaseOrder.Status = canvasI.Status;
			purchaseOrder.BrandName = canvasI.BrandName;

			_purchaseOrder.Add(purchaseOrder);
			await _purchaseOrder.SaveChangesAysnc();


			var rawMaterialDto = purchaseOrder.Adapt<PurchaseOrderResponce>();
			return rawMaterialDto;
		}
	}
}
