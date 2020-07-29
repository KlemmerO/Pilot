using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parol
{
    public class ParolLoibrary
    {
        public void input_password()
        {
            string str;
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
