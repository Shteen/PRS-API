using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRS.Core.Models.Responce
{
	public class CategoryCodeResponse
	{
		public Guid Id { get; set; }

		public string CategoryName { get; set; }
		public string DNOTYPE { get; set; }
		public string CategCode { get; set; }
	}
}
