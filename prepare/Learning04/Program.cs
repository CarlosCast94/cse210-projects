using System;

class Program
{
    static void Main(string[] args)
    {
       Assingment Assingment1 = new Assingment ("Carlos","Math");
       Console.WriteLine(Assingment1.GetSummary());

       MathAssingment m1 = new MathAssingment ("Carlos","Problems","Section 1","1-3");
       Console.WriteLine(m1.GetHomeworkList());
       Console.WriteLine(m1.GetSummary());

       WritingAssignment w1 = new WritingAssignment ("Miguel","World","Best battles");
       Console.WriteLine(w1.GetSummary());
       Console.WriteLine(w1.GetWritingInformation());


    }
}