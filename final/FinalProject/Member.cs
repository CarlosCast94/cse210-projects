public class Member
{
     protected List<string> _RandomMember = new List<string> ();

      public Member (List<string> RandomMember)
    {
        _RandomMember = RandomMember;
       
    }

     public string GetRandomMember()
    {
        Random Prompt = new Random();
        int x = Prompt.Next(_RandomMember.Count);
        string y = _RandomMember[x];
        _RandomMember.RemoveAt(x);
        return y;
    }

    public virtual void DisplayMember()
    {
        
    }

}