public class Goal
{
    protected string _name;

    protected string _description;

    protected int _points;

    protected int _bonus;

    protected int _totalPoints;

    protected string _check = "[ ]";

    public string GetCheck()
    {
        return _check;
    }
    public  void SetCheck( string check)
    {
        _check = check;
    }

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

    public  virtual void PrintGoal()
    {
        Console.WriteLine ($"{_check } {_name} ({_description}) ");
        Console.WriteLine($"You have {_totalPoints}");

    }

    public virtual void LoadFile()
    {

    }

    public virtual string SaveFile()
    {
        
        return $"{_name} {_description} {_points} ";
    }
  

    public void SetName(string name)
    {
        _name = name;

    }
    public void SetDescription( string description)
    {
        _description = description;
    }

    public void SetPoint (int points)
    {
        _points = points;
    }
    public void SetBonus ( int bonus)
    {
        _bonus = bonus;
    }



    public virtual int RecordEvent()
    {   
        return 0;

    }

    public virtual bool Iscomplete()
    {
        return true;
    }

}