public class Activity
{
    protected string _welcomeMessage = "";
    protected string _description = "";
    private int _duration;

    public Activity (int duration)
    {
        _duration = duration;
    }
    public void DisplayWelcomeMessage()
    {
        Console.WriteLine(_welcomeMessage);
    }

    public void DisplayDescription()
    {
        Console.WriteLine(_description);
    }
    public string DisplayEnding()
    {
        return $"Well done!! You have completed another {_duration} seconds of the {_welcomeMessage}";
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
    public void PausingShowingCountdownTime(int number)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(number);

       while (DateTime.Now <endTime && number>0)
        {

            Console.Write(number);
            Thread.Sleep(1000);
            if(number.ToString().Length == 1 )
            {
                Console.Write("\b \b");
            }
            else
            {
                Console.Write("\b \b\b \b");
            }
           

            number--;
            

        
        }


    }
}