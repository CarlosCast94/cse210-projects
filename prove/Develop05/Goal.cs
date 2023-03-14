public class Goal
{
    protected string _name;

    protected string _description;

    protected int _points;

    protected int _bonus;

    public string GetName()
    {
        return _name;

    }
    public string GetDescription()
    {
        return _description;
    }
    public  int GetPoint()
    {
        return _points;
    }
     public int GetBonus()
    {
        return _bonus;
    }

      public virtual void GetGoal()
    {
         Console.WriteLine("What is the name of your goal?");
        _name = Console.ReadLine();
        Console.WriteLine("What is a short description of it?");
        _description = Console.ReadLine();
        Console.WriteLine("What is the amount of points associated with this goal");
        _points = int.Parse(Console.ReadLine());
        
    }



    public virtual int RecordEvent()
    {   
        return 0;

    }

    public virtual bool Iscomplete()
    {
        return true;
    }



    public virtual void LoadFromFile()

    {  
         


    }
}