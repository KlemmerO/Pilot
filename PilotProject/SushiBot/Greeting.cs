﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Text;

namespace SushiBot
{
    class Greeting
    {
        public static string GetTimeOfDay()
        {
            TimeSpan currentTime = DateTime.Now.TimeOfDay;
            string timeOfDay;
            switch (currentTime.Hours)
            {
                case int hour when (hour >= 8 && hour < 12):
                    return timeOfDay = " morning";
                case int hour when (hour >= 12 && hour < 15):
                    return timeOfDay = " day";
                case int hour when (hour >= 15 && hour < 22):
                    return timeOfDay = " evening";
                default:
                    return " night";
            }
        }
        public Greeting()
        {
            Console.WriteLine($"Good{GetTimeOfDay()},Mr/Ms. You are welcome to our Sushi Bar!");           
        }     
    }
}
