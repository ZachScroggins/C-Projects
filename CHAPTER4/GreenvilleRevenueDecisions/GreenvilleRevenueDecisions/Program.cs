//Filename GreenvilleRevenueDecisions
//Written by Zach Scroggins
//Written on Setpember 20, 2019

using System;
using static System.Console;

namespace GreenvilleRevenueDecisions
{
    class Program
    {
        static void Main()
        {

            const double ENTRANCE_FEE = 25.00;
            int contestantsLastYear, contestantsThisYear;
            double expectedRevenue;

            WriteLine("Greenville County Fair Revenue Information:");
            WriteLine("");
            Write("Enter the number of contestants last year>> ");
            contestantsLastYear = Convert.ToInt32(ReadLine());
            Write("Enter the number of contestants this year>> ");
            contestantsThisYear = Convert.ToInt32(ReadLine());

            expectedRevenue = ENTRANCE_FEE * contestantsThisYear;

            WriteLine("");
            WriteLine("There were {0} contestants last year.", contestantsLastYear);
            WriteLine("There are {0} contestants this year.", contestantsThisYear);
            WriteLine("This year's expected revenue " +
                "with $25 entrance fee: {0}", expectedRevenue.ToString("C"));
            if (contestantsThisYear > (contestantsLastYear * 2))
                WriteLine("The competition is more than twice as big this year!");
            else if (contestantsThisYear > contestantsLastYear && contestantsThisYear < (contestantsLastYear * 2))
                WriteLine("The competition is bigger than ever!");
            else if (contestantsThisYear < contestantsLastYear)
                WriteLine("A tighter race this year! Come out and cast your vote!");
        }
    }
}