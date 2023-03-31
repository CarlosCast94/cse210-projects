public class SundaySchool : Agenda
{
     public SundaySchool()
    {
        

    }

     public override string SaveFile()
    {
         
        return $" Sunday School - {_date } {_description} ";
    
    }
}