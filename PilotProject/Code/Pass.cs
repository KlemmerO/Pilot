using System;

namespace Code
{
    class Pass
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
}
