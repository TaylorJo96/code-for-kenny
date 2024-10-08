﻿using System;

namespace LogicalBranchingTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            /* *********** Logical Branching Tutorial ***********
            * In this tutorial, you will write some boolean expressions and use them to
            * control the flow of your program using if / else statements.
            * This program tells the user how to prepare for their day based on weather conditions.
            * *************************************************/

            // Step One: Greet the user
            Console.WriteLine("**************************************");
            Console.WriteLine("*** Welcome to the Weather Station ***");
            Console.WriteLine("**************************************");

            // Step Two: Declare and initialize Weather Station variables

            int highTemperatureF = 55;                           //high temp for today
            bool precipitaitonExpected = true;                   //wheather or not its supposed to rain
            const int freezingTemperatureF = 32;                 // this is a constant representing the freezing point
            // Step Three: Report today's expected conditions to the user.

            Console.WriteLine("Expected high temperature: " +highTemperatureF+"\u00B0F.");      //\u00B0 is the degree symbol
            if (precipitaitonExpected)
            {
                Console.WriteLine("The chance of precipitation is high.");
            }
            else
            {
                Console.WriteLine("The chance of precipitaiton is low.");
            }
            // Step Four: Determine if the user should bring a coat. (when the temperature < 65°F)
            if (highTemperatureF < 65)
            {
                Console.WriteLine("*Don't forget to bring a coat today.");
            }


            // Step Five: Determine if the user should bring an umbrella
            bool isAboveFreezing = highTemperatureF > freezingTemperatureF;
            if (precipitaitonExpected && isAboveFreezing)
            {
                Console.WriteLine("*Be sure to pack an umbrella!");
            }


            // Step Six: Advise the user on the type of jacket they should be wearing. (<= 0°F, <= freezing, < 65°F)

            if (highTemperatureF <= 0)
            {
                Console.WriteLine("* Bundle up! Wear everything you have!");
            }
            else if (!isAboveFreezing)
            {
                Console.WriteLine("* Please wear a warm winter coat!");
            }
            else if (highTemperatureF < 65)
            {
                Console.WriteLine("* Take along a light jacket.");
            }

            // Step Seven: If the temperature delta for the day is more than 20°F, advise the user to dress in layers.

            int lowTemperatureF = 34;
            if (highTemperatureF - lowTemperatureF > 20)
            {
                Console.WriteLine("* Dress in layers today, as the temperature may swing dramatically.");
            }
        }
    }
}
