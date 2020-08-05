using System;
using System.Collections.Generic;
using System.Linq;
using System.Dynamic;
using System.Text;

namespace Menu
{
	public class Syshi
	{		
		public string SushiName { get; set; }
		public double Price { get; set; }
		public int StandardID { get; set; }
		public List<string> Ingridient { get; set; }
	}

	public class Standard
	{

		public int StandardID { get; set; }
		public string StandardTyp { get; set; }
	}
}
