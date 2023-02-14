using System;
using System.IO;

public class MyJournal
{
    
public List <Entry> _entries = new List<Entry>();



public void AddEntry2()
{
    Entry newEntry = new Entry();
    newEntry.AddEntry();
    _entries.Add(newEntry);
        
}

public void DisplayEntries()
{
    foreach(Entry entry in _entries)
    {

         Console.WriteLine($"{entry._date} {entry._prompt} {entry._answer}");
    }
        
}

public void SavingToFile()
{
    Console.WriteLine("Enter a file Name with a file extension (txt)");
    string fileName =  Console.ReadLine();

    using (StreamWriter outputFile = new StreamWriter(fileName))
    {
       foreach(Entry entry in _entries)
       {
        outputFile.WriteLine($"{entry._date} -{entry._prompt} -{entry._answer}");
       }
    }

}
public void LoadFromFile()

{
  _entries.Clear();
  Console.WriteLine("What file would you like to load");
  string fileName = Console.ReadLine();
  string[] lines = System.IO.File.ReadAllLines(fileName);

    foreach (string line in lines)
    {  
        Entry AllData = new Entry();
        string[] parts = line.Split(" -");
        AllData._date = parts[0];
        AllData._prompt = parts[1];
        AllData._answer = parts[2];
        _entries.Add(AllData);

    }


}

}