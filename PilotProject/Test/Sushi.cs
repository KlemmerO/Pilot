using System;
using System.Collections.Generic;
using System.Text;

namespace JsonLibrary
{
    [Serializable]
    public class Sushi
    {
        public int SushiNr { get; set; }
        public string SushiName { get; set; }
        public double Price { get; set; }
        public string Ingridient { get; set; }        
        public Type Type { get; set; }        
        public Sushi(int sushiNr, string sushiName, double price, string ingridient)
        {
            SushiNr = sushiNr;
            SushiName = sushiName;
            Price = price;
            Ingridient = ingridient;
        }
        public override string ToString()
        {
            return SushiName;
        }
    }
}
