using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ppt.Shared
{
	public class RevizeViewModel
	{
		public string nazev { get;set; }
		public Guid Id { get; set; }
		public RevizeViewModel(string nazev) { 
			this.nazev = nazev;
			this.Id = Guid.NewGuid();
		}
		public static RevizeViewModel generateRand()
		{
			return new RevizeViewModel(Random.Shared.Next(54000, 99999).ToString());
		}
	}
	
}
