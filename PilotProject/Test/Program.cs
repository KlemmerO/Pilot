using System;
using System.Linq;
using System.Collections.Generic;

namespace Test
{
    class Program
    {
		public static void Main()
		{			
			IList<Sushi> sushiList = new List<Sushi>() {
			new Sushi() { SushiNr = 1, SushiName = "Akita", Price = 3,   Type = "Nigiri" } ,
			new Sushi() { SushiNr = 2, SushiName = "Steve",  Price = 1, Type = "Gunkani" } ,
			new Sushi() { SushiNr = 2, SushiName = "Steve",  Price = 1.4, Type = "Gunkani" } ,
			new Sushi() { SushiNr = 3, SushiName = "Steve",  Price = 1.8, Type = "Gunkani" } ,
			new Sushi() { SushiNr = 2, SushiName = "Steve",  Price = 2, Type = "Gunkani" } ,			
	  	    };			

			var sushiNames = sushiList.Where(s => s.Price < 2)
									  .Select(s => s)
									  .Where(st => st.SushiNr > 0)
									  .Select(s => s.SushiName);


				foreach (var name in sushiNames)
				{
					Console.WriteLine(name);
				}
			var queryFluent =sushiNames
						.where(m Sushi.Equals("3")
						select m;

			foreach (var m in query)
			{
				Console.WriteLine(m + " ");
			}
		}
	}

		public class Sushi
		{

			public int SushiNr { get; set; }
			public string SushiName { get; set; }
			public double Price { get; set; }
			public string Type { get; set; }
		}
	}
