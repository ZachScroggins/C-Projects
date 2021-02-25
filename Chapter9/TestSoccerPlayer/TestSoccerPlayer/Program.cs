//Filename TestSoccerPlayer
//Written by Zach Scroggins
//Written on November 2, 2019

using System;
using static System.Console;

class TestSoccerPlayer
{
    static void Main()
    {
        SoccerPlayer firstPlayer = new SoccerPlayer
        {
            PlayerName = "John",
            JerseyNumber = 76,
            GoalsScored = 2,
            Assists = 1
        };
        firstPlayer.DisplayPlayer();
    }

}

class SoccerPlayer
{
    public string PlayerName { get; set; }
    public int JerseyNumber { get; set; }
    public int GoalsScored { get; set; }
    public int Assists { get; set; }

    public void DisplayPlayer()
    {
        WriteLine("Team member {0} with jersey number {1} scored {2} goals " +
            "and {3} assists.", this.PlayerName, this.JerseyNumber,
            this.GoalsScored, this.Assists);
    }

}
