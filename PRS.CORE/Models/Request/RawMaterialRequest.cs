using PRS.Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRS.Core.Models.Request
{
	public class RawMaterialRequest
	{

		public string RawMaterialName { get; set; }
		public string CategoryName { get; set; }
		public string ItemDes { get; set; }
		public string UM { get; set; }
		public double CurrentInventory { get; set; }


	}
}
