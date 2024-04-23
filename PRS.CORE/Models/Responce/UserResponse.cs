using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRS.Core.Models.Responce
{
	public class UserResponse
	{
		public Guid Id { get; set; }
		public string supplierName { get; set; }
		public int supno { get; set; }
		public int number1 { get; set; }
		public string keyperson { get; set; }
		public string terms { get; set; }
		public string primryAdd1 { get; set; }
		public string primryAdd2 { get; set; }
		public string physcladd1 { get; set; }
		public string physcladd2 { get; set; }
		public string tin { get; set; }
		public string registeredName { get; set; }
		public string supplierType { get; set; }
		public string businessType { get; set; }
		public string natureofBusiness { get; set; }
		public string secdtiRegno { get; set; }
		public int dtidate { get; set; }
		public string bussnssPermit { get; set; }
		public string segreg { get; set; }
		public string mailto { get; set; }
		public string owner { get; set; }
		public string ceoPres { get; set; }
		public string comptroller { get; set; }
		public string name1 { get; set; }
		public string name2 { get; set; }
		public string number2 { get; set; }
		public string supEmailAdd { get; set; }
		public bool payee { get; set; }
		public bool vat { get; set; }
		public bool nonvat { get; set; }
		public bool avl { get; set; }
		public bool trucker { get; set; }
		public bool domestic { get; set; }
		public bool IsActive { get; set; }
	}
}
