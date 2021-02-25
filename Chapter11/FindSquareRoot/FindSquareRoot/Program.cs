//Filename FindSquareRoot
//Written by Zach Scroggins
//Written on November 15, 2019

/*Create a program named FindSquareRoot that finds the square root of a user's input value.
 The Math class contains a static method named Sqrt() that accepts a double and returns the 
 parameter's square root. If the user's entry cannot be converted to a double, display an appropriate
 message, and set the square root value to 0. Otherwise, test the input number's value.
 If it is negative, throw a new ApplicationException to which you pass the message 
 "Number can't be negative." and again set sqrt to 0. If the input value is a double and not negative,
 pass it to the Math.Sqrt() method, and display the returned value.*/

using System;
using static System.Console;
using static System.Math;

class FindSquareRoot
{
    static void Main()
    {
        string inputString;
        double number;
        try
        {
            Write("Enter a number to find the square root >> ");
            inputString = ReadLine();
            double.TryParse(inputString, out number);
            while (!double.TryParse(inputString, out number))
            {
                number = 0;
                WriteLine("Input was not formatted correctly...");
                Write("Enter a number to find the square root >> ");
                inputString = ReadLine();
            }
            if (number < 0)
            {
                throw (new NegativeNumberException());
            }
        }
        catch(NegativeNumberException e)
        {
            WriteLine(e.Message);
            number = 0;
        }
        Sqrt(number);
        WriteLine("");
        WriteLine("The square root is: {0}", Sqrt(number));
    }
}

class NegativeNumberException : ApplicationException
{
    private static readonly string msg = "Number can't be negative. ";
    public NegativeNumberException() : base(msg)
    {
    }
}

