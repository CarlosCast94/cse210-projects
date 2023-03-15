using System;

class Program
{
    static void Main(string[] args)
    {
        int opcion = 0;
        SimpleGoal Sgoal = new SimpleGoal();
        EGoal EternalGoal = new EGoal();
        CGoal ChecklistGoal = new CGoal();
        List<Goal> goals = new List<Goal>();
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
                                    Sgoal.GetGoal();
                                    goals.Add(Sgoal);
                                        break;
                                    case 2:
                                    EternalGoal.GetGoal();
                                    goals.Add(EternalGoal);
                                        break;
                                    case 3:
                                    ChecklistGoal.GetGoal();
                                    goals.Add(ChecklistGoal);
                                        break;
                                     default:
                                        Console.Write("Please enter a valid choice:\n");
                                        break;
                                    
                                }

                                break;
                            case 2:
                            foreach (Goal y in goals)
                            {
                               y.PrintGoal();

                            }

                                break;
                            case 3:
                                Console.WriteLine("Enter a file Name with a file extension (txt)");
                                    string fileName =  Console.ReadLine();

                                    using (StreamWriter outputFile = new StreamWriter(fileName))
                                    {
                                    foreach(Goal x in goals)
                                    {
                                        
                                        outputFile.WriteLine(x.SaveFile());
                                    }
                                    }
                                break;
                            case 4:
                             {      
                                    goals.Clear();
                                    Console.WriteLine("What file would you like to load");
                                    fileName = Console.ReadLine();
                                    string [] fileComplete = System.IO.File.ReadAllLines(fileName);
                                    foreach(Goal x in  goals)
                                    {
                                        string [] parts = x.Split(" -");
                                        
                                    }


                             }
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