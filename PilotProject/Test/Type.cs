using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace JsonLibrary
{
    [DataContract]
    public class Type
    {
        private readonly Random num = new Random();
        public int Number { get; set; }
        public Type() 
        {
            Number = num.Next(1, 40);            
        }
        public Type(int number) 
        {
            Number = number;
        }
        public override string ToString()
        {
            return Number.ToString();
        }
    }
}
