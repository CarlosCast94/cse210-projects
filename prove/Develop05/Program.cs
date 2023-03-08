using System;

class Program
{
    static void Main(string[] args)
    {
        int opcion = 0;
        while (opcion !=6)
        {
                Console.WriteLine("Menu options:\n"+
                "\n1.Create a new goal"+
                "\n2.List goals"+
                "\n3.Save goals"+
                "\n4.Load Goals"+
                "\n5.Record Events"+
                "\n6.Quit");
                opcion = int.Parse(Console.ReadLine());
                switch(opcion){


                            case 1:
                            int answer = 0;
                             Console.WriteLine("The types of goals are:\n"+
                                "\n1.Simple Goal"+
                                "\n2.Eternal Goal"+
                                "\n3.Checklist Goal"+
                                "\n Wich type of goal would you like to create?");
                                answer = int.Parse(Console.ReadLine());
                                switch(answer)
                                {
                                    case 1:
                                        break;
                                    case 2:
                                        break;
                                    case 3:
                                        break;
                                    
                                }


                                break;
                            case 2:
                                break;
                            case 3:
                                break;
                            case 4:
                                break;
                            case 5:
                                break;
                            case 6:
                                Console.WriteLine("Goodbye");
                                break;
                            default:
                                Console.Write("Please enter a valid choice:\n");
                                break;

                    }
        }

    }
}