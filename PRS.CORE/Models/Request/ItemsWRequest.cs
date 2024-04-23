using PRS.Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRS.Core.Models.Request
{
	public class ItemsWRequest
	{
		public string CategoryCode { get; set; }
		
		public int EIitem { get; set; }
		
		public string ItemName { get; set; }
		public string DescriptionItem { get; set; }
		public string DNONUMBER { get; set; }
		public decimal? taxrate { get; set; }
		public string? UMPC { get; set; }
		public decimal? CostPC { get; set; }
		public string? UMCS { get; set; }
		public decimal? CostCS { get; set; }
		public int? PCCS { get; set; }
	}
}
