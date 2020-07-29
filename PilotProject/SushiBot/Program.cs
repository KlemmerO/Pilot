using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace SushiBot
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Greeting greeting = new Greeting();
            Console.WriteLine();
            ConsoleKeyInfo booked;
            do
            {               
                Console.WriteLine("Do You have already ordered the sushu _Y,_N?");
                booked = Console.ReadKey();             
            } while (booked.Key != ConsoleKey.N);
            Console.WriteLine();
            Console.WriteLine("Do You want Gunkan or Nigiri?");

            SushiInformation sushiInfo = new SushiInformation();



        }
        public static void Second()
        {
            SushiInformation sushiInfo = new SushiInformation()
            {
                Number = 1,
                Price = 2.40,
                Name = "Spicy Gunkan",
                Consist = new List<string>()
                {
                    "tuna",
                    "rice",
                    "sauce"
                }
            };
            string strResultJson = JsonConvert.SerializeObject(sushiInfo);
            File.WriteAllText(@"sushiInfo.json", strResultJson);
            Console.WriteLine("Stored!");
        }
    }
}
