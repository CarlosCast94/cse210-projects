public class Agenda
{
   
    protected string _description;

    protected string _date;

    public string Date()
    {
        return DateTime.Now.ToShortDateString();
    }

    public virtual void GetAgenda()
    {
        Console.WriteLine("Please write the must important points of the meeting");
        _description = Console.ReadLine();
        
    }

     public virtual string SaveFile()
    {
        
        return $"{_date }{_description} ";
    }



}