using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PRS.Core.Entites
{
	public class Brand
	{

		public Guid Id { get; set; }
		public string BrandNumber { get; set; }
		public string BrandName { get; set; }
		[JsonIgnore]
		public ICollection<Canvas> Canvass { get; set; }

	}
}
