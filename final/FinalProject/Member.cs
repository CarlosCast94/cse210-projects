public class Member 
{
     protected List<string> _RandomMember = new List<string>
    {
     "President Nolasco",
     "Betty Popoca",
     "Bishop",
     "Adan Cholula",
     "Efrain Gomez",
     "Erika Coraza",
     "Guadalupe Palacios",
     "Carlos Castañeda",
     "Paulina Navarro"
    };

     public string GetRandomMember()
    {
        Random Prompt = new Random();
        int x = Prompt.Next(_RandomMember.Count);
        string y = _RandomMember[x];
        Console.WriteLine($"{y}");
        return y;
    }

    public virtual void DisplayMember()
    {
        
    }

}