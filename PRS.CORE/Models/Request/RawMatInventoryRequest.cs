using PRS.Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRS.Core.Models.Request
{
	public class RawMatInventoryRequest
	{

		public string RawMatInvNumber { get; set; }
		public string CVSNO { get; set; }
		public string CategoryName { get; set; }
		public string DNO { get; set; }
		public string RawMatName { get; set; }
		public string ItemDes { get; set; }
		public string UM { get; set; }
		public double QTY { get; set; }
		public double UCaVat { get; set; }
		public double DeliveryDate { get; set; }
		public double EXP { get; set; }

	}
}
