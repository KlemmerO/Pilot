using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;


namespace JsonLibrary
{
    public class Sushi
    {
        public string Type { get; set; }
        public int SushiNr { get; set; }
        public string SushiName { get; set; }
        public double Price { get; set; }
        public bool Rice { get; set; }
        public bool Fish { get; set; }
        public List<string> Ingridient { get; set; }
        public IList<Sushi> _sushi { get; set; }
    }
}
  