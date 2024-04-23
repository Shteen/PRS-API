using PRS.Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRS.Core.Models.Responce
{
	public class RecivingReportResponce
	{
		public Guid Id { get; set; }
		public string RRnum { get; set; }
		public string RRdate { get; set; }
		public string PONumber { get; set; }
		public string CVSNO { get; set; }
		public string RawMaterialName { get; set; }
		public string Factory { get; set; }
		public string DateOrder { get; set; }
		public string Company { get; set; }
		public string Department { get; set; }
		public string ReqDescript { get; set; }
		public string ReqBy { get; set; }
		public string Type { get; set; }
		public bool ppe { get; set; }
		public string Remarks { get; set; }
		public string EI { get; set; }
		public string SuppIName { get; set; }
		public string SuppNum { get; set; }
		public string TellNo { get; set; }
		public string ContactP { get; set; }
		public string paymenTerms { get; set; }
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
