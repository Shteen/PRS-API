using PRS.Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRS.Core.Models.Request
{
	public class CanvasRequest
	{

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
		public int? supno { get; set; }
		public string ItemName { get; set; }
		public string QTY { get; set; }
		public string Total { get; set; }
		public string Status { get; set; }
		public string? BrandName { get; set; }

	}
}
