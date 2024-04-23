using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PRS.Core.Entites
{
	public class RecivingReport
	{
		public Guid Id { get; set; }
		public string RRnum { get; set; }
		public string RRdate { get; set; }
		public string PONumber { get; set; }
		public string CVSNO { get; set; }
		public string RawMaterialName { get; set; }
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
		public string DNO { get; set; }
		public string ItemDes { get; set; }
		public string UM { get; set; }
		public double QTY { get; set; }
		public double UCb4Vat { get; set; }
		public double UCaVat { get; set; }
		public double vat { get; set; }
		public double TotalCost { get; set; }
		public string Status { get; set; }
		public double POorderQTY { get; set; }
		public double POBalanceQTY { get; set; }
		public double POenterdQTY { get; set; }



	}
}
