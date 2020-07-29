using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParolLibrary;

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
            if (text.Key == ConsoleKey.Y)
            {
                Console.WriteLine(); 
            }
            if (text.Key == ConsoleKey.N)
            {
                Parol parol = new Parol(); 
                parol.input_password();
                Console.ReadLine();
            }
        }
    }
}
