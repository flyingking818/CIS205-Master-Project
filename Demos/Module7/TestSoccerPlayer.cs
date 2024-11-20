using static System.Console;
class TestSoccerPlayer
{
    static void Main()
    {
        SoccerPlayer mySoccerPlayer = new SoccerPlayer();
        mySoccerPlayer.Name = "Lionel";
        mySoccerPlayer.JerseyNum = 9;
        mySoccerPlayer.Goals = 8;
        mySoccerPlayer.Assists = 35;

        WriteLine($"The SoccerPlayer is {mySoccerPlayer.Name}. Jersey is #{mySoccerPlayer.JerseyNum}.");
        WriteLine($"Goals: {mySoccerPlayer.Goals}. Assists: {mySoccerPlayer.Assists}.");
    }
}

class SoccerPlayer
{
    public string Name { get; set; }
    public int JerseyNum { get; set; }
    public int Goals { get; set; }
    public int Assists { get; set; }

}

