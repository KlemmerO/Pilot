using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PasswordLibrary;
using JsonLibrary;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text.Json.Serialization;
using Menu;
using Newtonsoft.Json.Schema;
using System.Xml.Serialization;

namespace SushiShop
{
    public class ReadJson
    {
        public class Sushi
        {
            public string Type { get; set; }
            public int SushiNr { get; set; }
            public double Price { get; set; }
            public string SushiName { get; set; }
            public bool Rice { get; set; }
            public bool Fish { get; set; }
        }
        public class Selection
        {
            public int TotalCount { get; set; }
            public List<Sushi> Sushi { get; set; }
        }
        //    public ReadJson()
        // {          
        //  Selection selection = JsonConvert.DeserializeObject<Selection>(File.ReadAllText(@"C:\\Users\\Olga.Notebook_Olga\\source\\Repos\\KlemmerO\\Pilot\\PilotProject\\Test\\bin\\Debug\\netcoreapp3.1\\SushiSelection.json"));

        //     Console.WriteLine(selection.MenuSushi[1].Type);    
        public void ConditionG()
        {
            List<Sushi> Sushis = new List<Sushi>()
        {
          new Sushi {Type = "Gunkani", SushiNr = 1, SushiName = "Spicy", Price = 1.15, Fish = true, Rice = true},
          new Sushi {Type = "Nigiri", SushiNr = 2, SushiName = "Ginoko", Price = 1.45, Fish = false, Rice = true},
          new Sushi {Type = "Gunkani", SushiNr = 3, SushiName = "Vasabi", Price = 0.79, Fish = false, Rice = true},
          new Sushi {Type = "Nigiri", SushiNr = 4, SushiName = "Arigavi", Price = 0.65, Fish = false, Rice = false},
        };

            var gunkani = from Sushi in Sushis
                          where Sushi.Type == "Gunkani"
                          select new { Type = Sushi.Type, Number = Sushi.SushiNr };

            foreach (var p in gunkani)
              Console.WriteLine($"{p.Type}, Number of order - {p.Number}");
            Console.WriteLine();
            Console.WriteLine("Do You want with fish _Y or no _N ?");
            ConsoleKeyInfo details;
            details = Console.ReadKey();
            if (details.Key == ConsoleKey.Y)
            {
                Console.WriteLine();
                var fish = from Sushi in Sushis
                           where Sushi.Fish == true
                           select new { Type = Sushi.Type, Number = Sushi.SushiNr };
                foreach (var f in fish)
                    Console.WriteLine($"{f.Type}, Number of order - {f.Number}");
            }
            if (details.Key == ConsoleKey.N)
            {
                Console.WriteLine();
                var caviar = from Sushi in Sushis
                             where Sushi.Type == "Gunkani"
                             where Sushi.Fish == false
                             select new { Type = Sushi.Type, Number = Sushi.SushiNr };
                foreach (var n in caviar)
                    Console.WriteLine($"{n.Type}, Number of order - {n.Number}");
            }
        }
    }    
}

