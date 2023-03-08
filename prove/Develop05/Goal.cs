public abstract class Goal
{
    private string _name;

    private string _description;

    private int _points;

     public Goal (string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    


    public virtual int RecordEvent()
    {   
        return 0;

    }

    public virtual bool Iscomplete()
    {
        return true;
    }



    public virtual void SavingToFile()
    {
        

    }

    public virtual void LoadFromFile()

    {  
         


    }
}