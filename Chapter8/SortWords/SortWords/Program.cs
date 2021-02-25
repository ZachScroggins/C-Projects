//Filename SortWords
//Written by Zach Scroggins
//Written on October 27, 2019

using System;
using static System.Console;
using static System.Array;

class SortWords
{
    private static void WordSorter(params string[] words)
    {
        Array.Sort(words);
        foreach (string word in words)
           Write("{0} ", word);
        WriteLine("\n-----------");
    }
        
    static void Main()
    {
        string[] tenWords = { "yellow", "blue", "red", "green", "black",
        "brown", "magenta", "cyan", "purple", "pink"};
            
        WordSorter("yellow");
        WordSorter("yellow", "blue");
        WordSorter("yellow", "blue", "red", "green", "black");
        WordSorter(tenWords);
    }
}
