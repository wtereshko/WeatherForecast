using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Weather_Forecast
{
   public class Program
    {
        /*2) Solve the following task using any convenient programming language
         Solve the following task using any convenient programming language
         Let’s imagine that you receive results of the weather for today in the following format: ‘+26C’. 
         Weather results can change.Please write part of the code which will return the following: 
         a) If the weather is from -50C to -1C return “It’s super cold today.Be sure you dressed well!”
         b) If the weather is from -0C to +10C return “It’s windy outside, but we are sure you will enjoy your day!”
         c) If the weather is from +11C to +30C return “It’s time for the outdoor walking!”
         d) If the weather is from +31 to 40 return “It's so hot outside!”
         e) If the weather is from +41 to 50 return return “Welcome to hell!”
         f) If the weather results do not match above values return “Please re-check results in 5 mins.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value");
            Console.WriteLine(GetResult(Console.ReadLine()));
        }

        public static string GetResult(string receiveResult)
        {
            double weatherValue;
            string receiveResultValue = Regex.Replace(receiveResult, @"[^0-9,.-]+", "");

            if (Double.TryParse(receiveResultValue.Replace('.', ','), out weatherValue))
            {
                return CheckWeather(weatherValue);
            }
            else
            {
                return "Please re-check results in 5 mins.";
            }
        }

        public static string CheckWeather(double weatherResult)
        {
            if (weatherResult >= -50 && weatherResult <= -1)
            {
                return "It’s super cold today.Be sure you dressed well!";
            }

            if (weatherResult >= 0 && weatherResult <= 10)
            {
                return "It’s windy outside, but we are sure you will enjoy your day!";
            }

            if (weatherResult >= 11 && weatherResult <= 30)
            {
                return "It’s time for the outdoor walking!";
            }

            if (weatherResult >= 31 && weatherResult <= 40)
            {
                return "It's so hot outside!";
            }

            if (weatherResult >= 41 && weatherResult <= 50)
            {
                return "Welcome to hell!";
            }

            return "Please re-check results in 5 mins.";
        }
    }
}