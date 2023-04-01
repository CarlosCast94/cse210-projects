public class Agenda
{
   
    protected string _description;

    protected string _date;

     public Agenda (string date, string description)
    {
        _date = date;
        _description = description;
    }

    public Agenda()
    {
        
    }

    public string Date()
    {
        return DateTime.Now.ToShortDateString();
    }

    public virtual void GetAgenda()
    {
        Console.WriteLine("Please write the must important points of the meeting");
        _date = Date();
        _description = Console.ReadLine();
        
    }

     public  virtual void PrintAgenda()
    {
        Console.WriteLine ($"{_date } - {_description} ");

    }

     public virtual string SaveFile()
    {
        
        return $"{_date } - {_description} ";
    }



}