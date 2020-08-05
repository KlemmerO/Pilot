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
using System.Windows.Forms;
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
            string jsonFromFile;

            Console.WriteLine();
            ConsoleKeyInfo answer;
            Console.WriteLine("Dou You want Gunkani _G or Nigiri_N ?");
            answer = Console.ReadKey();
            if (answer.Key == ConsoleKey.G)
            {
                ReadOnly read = new ReadOnly();
                using (var reader = new StreamReader(_path))
                {
                    jsonFromFile = reader.ReadToEnd();
                }

            }            
        }
        public class ReadOnly
        {
            private readonly string _path = $"C:\\Users\\Olga.Notebook_Olga\\source\\Repos\\KlemmerO\\Pilot\\PilotProject\\Test\\bin\\Debug\\netcoreapp3.1\\SushiLibrary.json";                           
        }
    }
}
