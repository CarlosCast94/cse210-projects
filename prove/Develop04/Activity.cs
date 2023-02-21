public class Activity
{
    private string _Activity;
    private string _Description;
    private int _Duration;

    public Activity (string Activity, string Description,int Duration)
    {
        _Activity = Activity;
        _Description = Description;
        _Duration = Duration;
    }
    public string DisplayStart()
    {
        return $"Welcome to the {_Activity} \n {_Description}";
    }
    public string DisplayEnding()
    {
        return $"Well done!! You have completed another {_Duration} seconds of the {_Activity}";
    }
}