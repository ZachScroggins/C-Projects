//Filename GreenvilleRevenueMethods
//Written by Zach Scroggins
//Written on October 12, 2019

using System;
using static System.Console;
using static System.Array;

namespace GreenvilleRevenue
{
    class Program
    {

        private static int contestantsLastYear, contestantsThisYear;
        private static readonly string[] validCodes = new string[4] { "S", "D", "M", "O" };
        private static string[] contestantNames = new string[contestantsThisYear];
        private static string[] talentCodes = new string[contestantsThisYear];

        private static int CountContestants(int year)
        {
            if(year == 1)
            {
                Write("Enter the number of contestants last year>> ");
                contestantsLastYear = Convert.ToInt32(ReadLine());
                while (contestantsLastYear > 30 || contestantsLastYear < 0)
                {
                    Write("Enter a valid number 0 - 30>> ");
                    contestantsLastYear = Convert.ToInt32(ReadLine());
                }
                return contestantsLastYear;
            }
            else
            {
                Write("Enter the number of contestants this year>> ");
                contestantsThisYear = Convert.ToInt32(ReadLine());
                while (contestantsThisYear > 30 || contestantsThisYear < 0)
                {
                    Write("Enter a valid number 0 - 30>> ");
                    contestantsThisYear = Convert.ToInt32(ReadLine());
                }
                return contestantsThisYear;
            }
        }

        private static void FillArrays()
        {
            WriteLine("Valid talent codes: singing = S, dancing = D, musical = M, other =O");

            for (int x = 0; x < contestantNames.Length; ++x)
            {
                Write("Enter contestant name>> ");
                contestantNames[x] = ReadLine();

                Write("Enter contestant's talent code>> ");
                string tempTalentInput = ReadLine();
                while (tempTalentInput != validCodes[0] && tempTalentInput != validCodes[1] &&
                    tempTalentInput != validCodes[2] && tempTalentInput != validCodes[3])
                {
                    Write("Enter a valid code (S, D, M, or O)>> ");
                    tempTalentInput = ReadLine();
                }
                talentCodes[x] = tempTalentInput;
            }
        }

        private static void CompareAttendance(int thisYear, int lastYear)
        {
            if (contestantsThisYear > (contestantsLastYear * 2))
                WriteLine("The competition is more than twice as big this year!");
            else if (contestantsThisYear > contestantsLastYear && contestantsThisYear < (contestantsLastYear * 2))
                WriteLine("The competition is bigger than ever!");
            else if (contestantsThisYear < contestantsLastYear)
                WriteLine("A tighter race this year! Come out and cast your vote!");
        }

        private static void ListContestants()
        {
            string[] validCodesPlus = new string[5] { "S", "D", "M", "O", "Z" };
            string codeInputPlus;

            do
            {
                Write("Enter a talent code or 'Z' to quit>> ");
                codeInputPlus = ReadLine();
                while (codeInputPlus != validCodesPlus[0] && codeInputPlus != validCodesPlus[1] &&
                    codeInputPlus != validCodesPlus[2] && codeInputPlus != validCodesPlus[3] &&
                    codeInputPlus != validCodesPlus[4])
                {
                    Write("Enter a valid talent code or 'Z' to quit>> ");
                    codeInputPlus = ReadLine();
                }
                if (codeInputPlus == "S")
                {
                    WriteLine("These contestants are singing:");
                    for (int z = 0; z < contestantNames.Length; ++z)
                    {
                        if (talentCodes[z] == "S")
                        {
                            WriteLine("");
                            WriteLine(contestantNames[z]);
                            WriteLine("");
                        }
                    }
                }
                else if (codeInputPlus == "D")
                {
                    WriteLine("These contestants are dancing:");
                    for (int z = 0; z < contestantNames.Length; ++z)
                    {
                        if (talentCodes[z] == "D")
                        {
                            WriteLine("");
                            WriteLine(contestantNames[z]);
                            WriteLine("");
                        }
                    }
                }
                else if (codeInputPlus == "M")
                {
                    WriteLine("These contestants are playing music:");
                    for (int z = 0; z < contestantNames.Length; ++z)
                    {
                        if (talentCodes[z] == "M")
                        {
                            WriteLine("");
                            WriteLine(contestantNames[z]);
                            WriteLine("");
                        }
                    }
                }
                else if (codeInputPlus == "O")
                {
                    WriteLine("These contestants are doing something else:");
                    for (int z = 0; z < contestantNames.Length; ++z)
                    {
                        if (talentCodes[z] == "O")
                        {
                            WriteLine("");
                            WriteLine(contestantNames[z]);
                            WriteLine("");
                        }
                    }
                }
                else if (codeInputPlus == "Z")
                {
                    Environment.Exit(0);
                }
            } while (0 < 1);
        }

        static void Main()
        {

            WriteLine("Greenville County Fair Revenue Information:");
            WriteLine("");

            CountContestants(1);
            CountContestants(2);

            contestantNames = new string[contestantsThisYear];
            talentCodes = new string[contestantsThisYear];

            FillArrays();


            int numSing = 0, numDance = 0, numMusic = 0, numOther = 0;

            for (int y = 0; y < talentCodes.Length; ++y)
            {
                if (talentCodes[y] == "D")
                    numDance++;
                else if (talentCodes[y] == "M")
                    numMusic++;
                else if (talentCodes[y] == "O")
                    numOther++;
                else if (talentCodes[y] == "S")
                    numSing++;
            }

            WriteLine("");
            WriteLine("Number of contestants in each talent category:");
            WriteLine("There are {0} contestants dancing.", numDance);
            WriteLine("There are {0} contestants playing musical instruments.", numMusic);
            WriteLine("There are {0} contestants singing.", numSing);
            WriteLine("There are {0} other contestants.", numOther);

            const double ENTRANCE_FEE = 25.00;
            double expectedRevenue;
            expectedRevenue = ENTRANCE_FEE * contestantsThisYear;

            WriteLine("");
            WriteLine("There were {0} contestants last year.", contestantsLastYear);
            WriteLine("There are {0} contestants this year.", contestantsThisYear);
            WriteLine("This year's expected revenue " +
                "with $25 entrance fee: {0}", expectedRevenue.ToString("C"));

            CompareAttendance(contestantsThisYear, contestantsLastYear);

            WriteLine("");

            ListContestants();
        }
    }
}