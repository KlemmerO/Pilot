﻿using System;

namespace PasswordLibrary
{
    public class Password
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
