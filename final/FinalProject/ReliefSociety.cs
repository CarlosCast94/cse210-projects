public class ReliefSociety : Agenda
{
     public ReliefSociety()
    {
        

    }

     public override string SaveFile()
    {
         
        return $" Relief Society- {_date } - {_description} ";
    
    }
}