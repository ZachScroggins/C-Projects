//Filename GreenvilleRevenue
//Written by Zach Scroggins
//Written on Setpember 3, 2019

using System;
using static System.Console;

namespace GreenvilleRevenue
{
    class Program
    {
        static void Main()
        {
            
            const double ENTRANCE_FEE = 25.00;
            int contestantsLastYear, contestantsThisYear;
            double expectedRevenue;
            bool moreThisYear;

            WriteLine("Greenville County Fair Revenue Information:");
            WriteLine("");
            Write("Enter the number of contestants last year>> ");
            contestantsLastYear = Convert.ToInt32(ReadLine());
            Write("Enter the number of contestants this year>> ");
            contestantsThisYear = Convert.ToInt32(ReadLine());

            expectedRevenue = ENTRANCE_FEE * contestantsThisYear;

            moreThisYear = contestantsThisYear > contestantsLastYear;

            WriteLine("");
            WriteLine("There were {0} contestants last year.", contestantsLastYear);
            WriteLine("There are {0} contestants this year.", contestantsThisYear);
            WriteLine("There are more contestants this year: {0}", moreThisYear);
            WriteLine("This year's expected revenue " + 
                "with $25 entrance fee: {0}", expectedRevenue.ToString("C"));
        }
    }
}