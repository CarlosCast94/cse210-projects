public class Hymns : Member
{
     protected List<string> _RandomHymns = new List<string>
    {
     "1.Ya rompe el alba",
     "2.El espiritu de Dios",
     "3.Ya regocijemos",
     "4.Bandera de Sión",
     "5.Oh Dios de Israel",
     "6.Israel, Jesus os llama",
     "7.Id, vosotros mensajeros",
     "8.Un angel del Señor",
     "9.Te damos Señor nuestras gracias",
     "10.Dios manda a profetas"
    };

     public string GetRandomHymn()
    {
        Random Prompt = new Random();
        int x = Prompt.Next(_RandomHymns.Count);
        string y = _RandomHymns[x];
        Console.WriteLine($"{y}");
        return y;
    }

     public  void DisplayHymn()
    {
        Console.WriteLine($"The direction of the music will be in charge of: {GetRandomMember()} ");
        Console.WriteLine($"We are going to sing the hymn: {GetRandomHymn()}");
    }
}