using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRS.Core.Models.Responce
{
	public class SupplierResponce
	{

		public Guid Id { get; set; }
		public string? supplierName { get; set; }
		public int? supno { get; set; }
		public int? number1 { get; set; }
		public string? keyperson { get; set; }
		public string? terms { get; set; }
	
	}
}
