using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRS.Core.Models.Responce
{
	public class LoginResponse
	{
		public string token {  get; set; }
		public bool IsTemporaryPassword { get; set; }
	}
}
