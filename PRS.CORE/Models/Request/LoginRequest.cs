using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRS.Core.Models.Request
{
	public class LoginRequest
	{
		public int EmployeeNumber { get; set; }

		public string Password { get; set; }
	}
}
