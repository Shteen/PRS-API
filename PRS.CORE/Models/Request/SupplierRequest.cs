using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRS.Core.Models.Request
{
	public class SupplierRequest
	{
		public string? supplierName { get; set; }
		public int? supno { get; set; }
		public int? number1 { get; set; }
		public string? keyperson { get; set; }
		public string? terms { get; set; }
		
	}
}