using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;

namespace BlockChain.Models
{
	public class Contact
	{
		public Guid Id { get; set; }
		public string ContactName { get; set; }
		public string Email { get; set; }
		public string Comm { get; set; }

	}
}
