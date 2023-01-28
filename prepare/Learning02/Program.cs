using System;

class Program
{
    static void Main(string[] args)
    {
          Job job1 = new Job();
          job1._jobTitle = "Ejecutivo de ventas";
          job1._company = "Tvcenlinea.com";
          job1._starYear = "2019";
          job1._endYear = "2024";

          Job job2 = new Job();
          job2._jobTitle = "Pathway Mentor";
          job2._company = "Bloom";
          job2._starYear = "2022";
          job2._endYear = "2025";

          Resume myresume = new Resume();
          myresume._name = "Carlos Castañeda";
          myresume._jobs.Add(job1);
          myresume._jobs.Add(job2);

         

         myresume.Display();
    }
}