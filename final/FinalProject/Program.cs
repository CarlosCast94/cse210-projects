using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> RandomMember = new List<string>
        {
            "President Nolasco",
            "Betty Popoca",
            "Bishop",
            "Adan Cholula",
            "Efrain Gomez",
            "Erika Coraza",
            "Guadalupe Palacios",
            "Carlos Castañeda",
            "Paulina Navarro",
            "Alfonso Popoca",
        };
        Agenda Nagenda = new Agenda();
        Prayer Nprayer = new Prayer(RandomMember);
        Spiritual Nspiritual = new Spiritual(RandomMember);
        Hymns NHymn = new Hymns(RandomMember);
        Elderes NElderes = new Elderes();
        ReliefSociety NSociety = new ReliefSociety();
        SundaySchool NSchool = new SundaySchool();
        List<Agenda> ag = new List<Agenda>();
        int opcion = 0;
        while (opcion !=7)
        {
                Console.WriteLine("Welcome to the ward council meeting:\n"+
                "\n1.Choose an hymn"+
                "\n2.Choose a member to pray"+
                "\n3.Choose a member for a spiritual thought"+
                "\n4. Create the agenda of the meeting"+
                "\n5.Save the agenda"+
                "\n6.Load the agenda"+
                "\n7.Quit");
                opcion = int.Parse(Console.ReadLine());
                switch(opcion){


                            case 1:
                            NHymn.GetRandomHymn();
                            NHymn.DisplayHymn();
                                break;
                            case 2:
                            Nprayer.DisplayMember();
                           
                                break;
                            case 3:
                            Nspiritual.DisplayMember();
                                break;
                            case 4:
                            int answer = 0;
                             Console.WriteLine("Select one of the organizations:\n"+
                                "\n1.Elders Quorum"+
                                "\n2.Relief Society"+
                                "\n3.Sunda School");
                                answer = int.Parse(Console.ReadLine());
                                switch(answer)
                                {
                                    case 1:
                                    NElderes.GetAgenda();
                                    ag.Add(NElderes);
                                        break;
                                    case 2:
                                    NSociety.GetAgenda();
                                    ag.Add(NSociety);
                                        break;
                                    case 3:
                                    NSchool.GetAgenda();
                                    ag.Add(NSchool);
                                        break;
                                     default:
                                        Console.Write("Please enter a valid choice:\n");
                                        break;
                                    
                                }
                                break;
                            case 5:
                              Console.WriteLine("Enter a file Name with a file extension (txt)");
                                    string fileName =  Console.ReadLine();

                                    using (StreamWriter outputFile = new StreamWriter(fileName))
                                    {
                                    foreach(Agenda x in ag)
                                    {
                                        
                                        outputFile.WriteLine(x.SaveFile());
                                    }
                                    }
                                break;
                            case 6:
                                break;
                            default:
                                Console.Write("Please enter a valid choice:\n");
                                break;

                    }
        }
    }
}