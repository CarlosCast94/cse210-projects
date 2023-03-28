using System;

class Program
{
    static void Main(string[] args)
    {
        Prayer Nprayer = new Prayer();
        Spiritual Nspiritual = new Spiritual();
        Hymns NHymn = new Hymns();
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
                            NHymn.DisplayHymn();
                                break;
                            case 2:
                            Nprayer.DisplayMember();
                           
                                break;
                            case 3:
                            Nspiritual.DisplayMember();
                                break;
                            case 4:
                                break;
                            default:
                                Console.Write("Please enter a valid choice:\n");
                                break;

                    }
        }
    }
}