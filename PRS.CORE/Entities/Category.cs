﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRS.Core.Entites
{
	public class Category
	{
		public Guid id {  get; set; }

		public string CategoryName { get; set; }

		public string CatDesc { get; set; }

		public string DNOTYPE { get; set; }

		public string CategoryCode { get; set; }

		public Guid CategoryCodeId { get; set; }

		public CategoryCode CategoryCodes { get; set; }
	}
}
