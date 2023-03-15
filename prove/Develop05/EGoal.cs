public class EGoal : Goal
{
     public EGoal()
    {
        

    }

     public override string SaveFile()
    {
         
        return $" Eternal Goal - {_name} - ({_description}) - {_points} ";
    
    }
}