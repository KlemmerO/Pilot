using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ParolLibrary
{
    public class Parol
    {
        public void input_password()
        {
            string str = "Admin";
            Console.WriteLine("please, input passowrd");
            str = Console.ReadLine();
            if (str != "admin")
            {
                Console.WriteLine("Not existent Name");
            }
            else if (str == "admin")
            {
                Console.WriteLine("Unlocked");
            }
        }
    }
}
