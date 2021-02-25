//Filename LetterDemo
//Written by Zach Scroggins
//Written on November 10, 2019

using System;
using static System.Console;

class LetterDemo
{
    static void Main()
    {
        Letter letterOne = new Letter();
        CertifiedLetter letterTwo = new CertifiedLetter();
        letterOne.RecipientName = "Bill";
        letterOne.DateMailed = "December 1st, 2018";
        letterTwo.RecipientName = "Joseph";
        letterTwo.DateMailed = "November 2nd, 2019";
        letterTwo.TrackingNumber = 7590;

        WriteLine(letterOne.ToString());
        WriteLine(letterTwo.ToString());
    }
}

class Letter
{
    public string RecipientName { get; set; }
    public string DateMailed { get; set; }

    public override string ToString()
    {
        return(GetType() + " was mailed to " + RecipientName + " on " + DateMailed);
    }
}

class CertifiedLetter : Letter
{
    public int TrackingNumber { get; set; }

    public override string ToString()
    {
        return(GetType() + " " + TrackingNumber + " was mailed to " + RecipientName + 
            " on " + DateMailed);
    }
}
