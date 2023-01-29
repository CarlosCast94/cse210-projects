using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the the Journal Program!");
        int opcion = 0;
        MyJournal journal = new MyJournal();
        while (opcion !=5)
        {
                Console.WriteLine("Please select one of the Following options:\n"+
                "\n1.Write"+
                "\n2.Display"+
                "\n3.Load"+
                "\n4.Save"+
                "\n5.Quit");
                opcion = int.Parse(Console.ReadLine());
                switch(opcion){


                            case 1:
                            journal.AddEntry2() ;
                                break;
                            case 2:
                            journal.DisplayEntries();

                                break;
                            
                            case 3:
                                journal.LoadFromFile();
                                break;
                            case 4:
                                journal.SavingToFile();
                                break;
                            case 5:
                                Console.WriteLine("Goodbye");
                                break;
                            default:
                                Console.Write("Please enter a valid choice:\n");
                                break;

                    }
        }


       

    

       
    }
}