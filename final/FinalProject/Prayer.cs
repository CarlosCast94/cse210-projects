public class Prayer: Member
{
    public override void DisplayMember()
    {
        Console.WriteLine($"Please help us with the prayer {GetRandomMember()} ");
    }
}