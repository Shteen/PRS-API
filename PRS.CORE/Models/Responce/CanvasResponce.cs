using PRS.Core.Entites;
using PRS.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRS.Core.Models.Responce
{
	public class CanvasResponse
	{


		public Guid Id { get; set; }
		public string CVSNO { get; set; }
		public string Factory { get; set; }
		public DateTime DateOrder { get; set; }
		public string Company { get; set; }
		public string Department { get; set; }
		public string ReqDescript { get; set; }
		public string ReqBy { get; set; }
		public string Type { get; set; }
		public bool ppe { get; set; }
		public string Remarks { get; set; }
		public string EI { get; set; }
		public string? supplierName { get; set; }
		public int? supno { get; set; }
		public int? number1 { get; set; }
		public string? keyperson { get; set; }
		public string? terms { get; set; }
		public string CategoryCode { get; set; }
		public string CatDesc { get; set; }
		public int EIitem { get; set; }
		public string DNOType { get; set; }
		public string ItemName { get; set; }
		public string DescriptionItem { get; set; }
		public string DNONUMBER { get; set; }
		public double? taxrate { get; set; }
		public string? UMPC { get; set; }
		public double? CostPC { get; set; }
		public string? UMCS { get; set; }
		public double? CostCS { get; set; }
		public double? PCCS { get; set; }
		public string QTY { get; set; }
		public string Total { get; set; }
		public string Status { get; set; }
		public string? BrandName { get; set; }


		public Guid brandID { get; set; }
		public Guid itemsWID { get; set; }

	}
}
