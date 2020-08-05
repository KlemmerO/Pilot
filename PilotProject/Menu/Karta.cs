using System;
using System.Linq;
using System.Collections.Generic;

namespace Menu
{
    class Karta
    {
        static void Main(string[] args)
        {
			IList<Syshi> sushiList = new List<Syshi>() {
			new Syshi() { SushiName = "Spicy", Price = 0.38, Ingridient = new List<string>(){ "ryce", "fish" }, StandardID = 1 } ,
			new Syshi() { SushiName = "Linca", Price = 1.12, Ingridient = new List<string>(){ "tuna", "alga" }, StandardID = 2 } ,
		};
		IList<Standard> standardList = new List<Standard>() {
			new Standard(){ StandardID = 1, StandardTyp="Standard 1"},
			new Standard(){ StandardID = 2, StandardTyp="Standard 2"},
			new Standard(){ StandardID = 3, StandardTyp="Standard 3"}
		};


			var sushiWithStandard = from s in sushiList
									  join stad in standardList
									  on s.StandardID equals stad.StandardID
									  select new
									  {
										  SushiName = s.SushiName,
										  StandardTyp = stad.StandardTyp
									  };

			sushiWithStandard.ToList().ForEach(s => Console.WriteLine("{0} is in {1}", s.SushiName, s.StandardTyp));


		}
	}
 }
