public class Prayer: Member
{

     public Prayer (List<string> RandomMember) : base (RandomMember)
    {
        
    }

    public override void DisplayMember()
    {
        Console.WriteLine($"Please help us with the prayer {GetRandomMember()} ");
    }

    
}