using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PasswordLibrary;

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
                Console.WriteLine(); 
            }
            if (text.Key == ConsoleKey.Y)
            {
                Password parol = new Password(); 
                parol.input_password();
                Console.ReadLine();
            }          
        }
        public void Menu()
        {
            Console.WriteLine("Dou You want Gunkani _G or Nigiri_N ?");

        }
    }
}
