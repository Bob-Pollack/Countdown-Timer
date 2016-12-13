﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountDownTimer
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = 0;
            int minutes = 0;
            int seconds = 0;

            Console.WriteLine("Please Enter A String for how long you want to count");
            Console.WriteLine("format: ##h##m##s");
            string inputString = Console.ReadLine();
            inputString = inputString.ToLower();

            int hoursIndex = inputString.IndexOf('h');
            string hoursText = "";
            if (hoursIndex > 0)
            {
                hoursText = inputString.Substring(0, hoursIndex);
            }
            bool success = int.TryParse(hoursText, out hours);

            int minutesIndex = inputString.IndexOf('m');
            string minutesText = "";
            if (minutesIndex > 0)
            {
                if (hoursIndex != -1)
                {
                    minutesText = inputString.Substring(hoursIndex + 1, minutesIndex - hoursIndex -1);
                }
                else
                {
                    minutesText = inputString.Substring(0, minutesIndex);
                }
            }
            bool success2 = int.TryParse(minutesText, out minutes);

            int secondsIndex = inputString.IndexOf('s');
            string secondsText = "";
            if (secondsIndex > 0)
            {
                if (minutesIndex != -1)
                {
                    secondsText = inputString.Substring(minutesIndex + 1, secondsIndex - minutesIndex - 1);
                }
                else
                {
                    if (hoursIndex != -1)
                    {
                        secondsText = inputString.Substring(hoursIndex + 1, secondsIndex - hoursIndex - 1);
                    }
                    else
                    {
                        secondsText = inputString.Substring(0, secondsIndex);
                    }
                }
            }
            bool success3 = int.TryParse(secondsText, out seconds);

            Console.WriteLine(hours + " hours " + minutes + " minutes " + seconds + " seconds");

            if (seconds > 60)
            {
                int extraMinutes = seconds / 60;
                minutes += extraMinutes;
                seconds = seconds % 60;                
            }
            if (minutes > 60)
            {
                int extraHours = minutes / 60;
                hours += extraHours;
                minutes = minutes % 60;
            }


            Console.WriteLine(hours + " hours " + minutes + " minutes " + seconds + " seconds");
            //Console.WriteLine(success + "..." + hours);
            //Console.WriteLine(success2 + ".." + minutes);
            //Console.WriteLine(success3 + "." + seconds);



            Console.ReadLine();
        }
    }
}
