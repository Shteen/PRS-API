using PRS.Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRS.Core.Models.Request
{
	public class PurchaseOrderRequest
	{

		public string PONumber { get; set; }
		public string CVSNO { get; set; }
	}
}
