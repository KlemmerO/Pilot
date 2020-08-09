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

namespace SushiShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Welcome welcome = new Welcome();
            Console.WriteLine();
            ConsoleKeyInfo text;
            Console.WriteLine("Do You have already Order _Y,_N?");
            text = Console.ReadKey();
            if (text.Key == ConsoleKey.N)
            {
                Menu();
            }
            if (text.Key == ConsoleKey.Y)
            {
                Password parol = new Password();
                parol.input_password();
                Console.ReadLine();
            }
        }
        public static void Menu()
        {    
            
            Console.WriteLine();           
            ConsoleKeyInfo answer;
            Console.WriteLine("Dou You want Gunkani _G or Nigiri_N ?");            
            answer = Console.ReadKey();
            if (answer.Key == ConsoleKey.G)
            {
                Console.WriteLine();
                ReadJson read = new ReadJson();
                read.ConditionG();
                Console.WriteLine();             
            }
            if (answer.Key == ConsoleKey.N)
            {
                Console.WriteLine();
                Alternative alternativ = new Alternative();
                alternativ.ConditionN();
                Console.WriteLine();                
            }
            Console.WriteLine("Your booking are sucsessful done!");
            Console.WriteLine("Write Your Name and Surname- it will be Yours password.Press after input enter");
            Console.ReadLine();
          //  input_password(out id);
        }   
        
    }    
}

