using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using JsonLibrary;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json.Converters;
using System.Text.Unicode;
using System.Security.Cryptography;
using System.ComponentModel;
using Newtonsoft.Json.Schema;

namespace JsonLibrary
{
	class MenuSushi
	{
		public static List<Sushi> Sushis;
		 static void Main(string[] args)
		{
			Selection selection = new Selection();
			{
				selection.TotalCount = 4;
				Sushis = new List<Sushi>();
				Sushi Sushi1 = new Sushi
				{
					Type = "Gunkani",
					SushiNr = 1,
					SushiName = "Spicy",
					Price = 1.15,
					Rice = true,
					Fish = true,
				};
				Sushi Sushi2 = new Sushi
				{
					Type = "Nigiri",
					SushiNr = 2,
					SushiName = "Ginoko",
					Price = 2,
					Rice = false,
					Fish = true,
				};
				Sushi Sushi3 = new Sushi
				{
					Type = "Gunkani",
					SushiNr = 3,
					SushiName = "Vasabi",
					Price = 0.79,
					Rice = true,
					Fish = true,
				};
				Sushi Sushi4 = new Sushi
				{
					Type = "Nigiri",
					SushiNr = 4,
					SushiName = "Arigavi",
					Price = 0.45,
					Rice = false,
					Fish = false,
				};
				Sushis.Add(Sushi1);
				Sushis.Add(Sushi2);
				Sushis.Add(Sushi3);
				Sushis.Add(Sushi4);
				selection.Sushi = Sushis;
				File.WriteAllText("SushiSelection.json", JsonConvert.SerializeObject(selection, Formatting.Indented));

			}

			//File.WriteAllText("SushiLibrary.json",JsonConvert.SerializeObject(sushis));
			//Console.WriteLine(sushis);
			//Sushi restoredSushi= JsonSerializer.Deserialize<Sushi>(json);
			//Console.WriteLine(restoredSushs.SushiNr);
			//var typ = JsonConvert.SerializeObject(sushis, Formatting.Indented); 
			//Sushi menu = JsonConvert.DeserializeObject<Sushi>(typ);

			//Console.WriteLine(typ.Count<Sushis>);
			//Console.WriteLine(typ.GetType))
		}
	}
}

			
