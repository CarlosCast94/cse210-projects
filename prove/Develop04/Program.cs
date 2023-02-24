using System;

class Program
{
    static void Main(string[] args)
    {
        Activity x = new Activity("","",10);
        x.PausingShowingSpinner();

        int opcion = 0;
        while (opcion !=4)
        {
                Console.WriteLine("Select a choice from the menu:\n"+
                "\n1.Start breathing activity"+
                "\n2.Start reflecting activity"+
                "\n3.Star listing activity"+
                "\n4.Quit");
                opcion = int.Parse(Console.ReadLine());
                switch(opcion){


                            case 1:
                                break;
                            case 2:
                                break;
                            case 3:
                                break;
                            case 4:
                                Console.WriteLine("Goodbye");
                                break;
                            default:
                                Console.Write("Please enter a valid choice:\n");
                                break;

                    }
        }


    }
}