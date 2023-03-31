public class Spiritual: Member
{

     public Spiritual (List<string> RandomMember) : base (RandomMember)
    {
        
    }

    public override void DisplayMember()
    {
        Console.WriteLine($"Please help us with a spiritual thought {GetRandomMember()} ");
    }
}