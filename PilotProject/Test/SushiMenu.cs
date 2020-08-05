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

namespace JsonLibrary
{
	class SushiMenu
	{
		static void Main(string[] args)
		{
			Sushi sushi = new Sushi();
			List<Sushi> sushis = new List<Sushi>();

			Sushi sushisA = new Sushi
			{
				Type = "Gunkani",
				SushiNr = 1,
				SushiName = "Spicy",
				Price = 1.15,
				Rice = true,
				Fish = true,
				Ingridient = new List<string>() { "rice", "fish" }
			};
			Sushi sushisB = new Sushi
			{
				Type = "Nigiri",
				SushiNr = 2,
				SushiName = "Ginoko",
				Price = 2,
				Rice = false,
				Fish = true,
				Ingridient = new List<string>() { "alga", "tuna" }
			};
			Sushi sushisC = new Sushi
			{
				Type = "Gunakni",
				SushiNr = 3,
				SushiName = "Vasabi",
				Price = 0.79,
				Rice = true,
				Fish = true,
				Ingridient = new List<string>() { "rice", "caviar" }
			};
			Sushi sushisD = new Sushi
			{
				Type = "Nigiri",
				SushiNr = 4,
				SushiName = "Arigavi",
				Price = 0.45,
				Rice = false,
				Fish = false,
				Ingridient = new List<string>() { "cheese", "crab" }
			};
			sushis.Add(sushisA);
			sushis.Add(sushisB);
			sushis.Add(sushisC);
			sushis.Add(sushisD);
			sushi._sushi = sushis;
			File.WriteAllText("SushiLibrary.json", JsonConvert.SerializeObject(sushis, Formatting.Indented));

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

			
