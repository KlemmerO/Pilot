using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace CodeBot.Models
{
    [Serializable]
    public class Client
    {
        public string Name { get; set; }
        public double Amount { get; set; }
        public Client(string name, double amount)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Missed Information");
            }
            if (amount >= 0)
            {
                throw new ArgumentNullException("Missed Information");
            }
            Name = name;
            Amount = amount;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
