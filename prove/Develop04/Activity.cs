public class Activity
{
    private string _activity;
    private string _description;
    private int _duration;

    public Activity (string activity, string description,int duration)
    {
        _activity = activity;
        _description = description;
        _duration = duration;
    }
    public string DisplayStart()
    {
        return $"Welcome to the {_activity} \n {_description}";
    }
    public string DisplayEnding()
    {
        return $"Well done!! You have completed another {_duration} seconds of the {_activity}";
    }

    public void PausingShowingSpinner()
    {
        List <string> AnimationString = new List<string> ()
        {
            "|" ,"/","-","\\"

        };
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        int i = 0;

       while (DateTime.Now <endTime)
        {
            string s = AnimationString [i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if (i>=AnimationString.Count)
            {
                i = 0;
            }
        }

    }
    public void PausingShowingCountdownTime()
    {

    }
}