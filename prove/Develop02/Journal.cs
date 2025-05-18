/* JOURNAL CLASS
Purpose: Write, Read, and Display Journal Entries
Attributes
- "_entries"
    - Type: List<Entry> (from the Entry class)
    - a list of the entries either written or loaded
- _

*/

using System.IO;
using System.Runtime.InteropServices;

public class Journal
{

    //declare a variable that will hold the file name // Maybe change this variable name because fileName is already used in main.
    public string fileName;

    // instantiate an object of the Entry class and assign it to a new empty list
    public List<Entry> entries = new List<Entry>();



    // create a method that will display the current journal entries
    public void Display()
    {
        // guard clause for empty journals
        if (entries.Count == 0)
        {
            Console.WriteLine("No entries to display. Try writing an entry or loading another file.");
            return;
        }

        // display a header for readability in the console
        Console.WriteLine("\n=== Journal Entries ===\n");

        // loop through each entry and display it with the Entry.Display() method
        foreach (Entry entry in entries)
        {
            entry.Display();
        }
    }

    // create the method to write to a file
    public void Write(string fileName)
    {
        // store the provided filename in the class field
        this.fileName = fileName;

        // use streamwriter to write the entries into the file
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            // loop through the entries and write the entry to the file in the predetermined format
            foreach (Entry entry in entries)
            {
                outputFile.WriteLine($"{entry.date.ToLongDateString()}|~|{entry.prompt}|~|{entry.response}|~|");
            }
        }

        // tell the user that the journal was saved
        Console.WriteLine($"Journal saved to {fileName}");
    }

    // create the method to read entries from a file
    public void Read(string fileName)
    {
        // store the filename
        this.fileName = fileName;

        // Clear existing entries from the entry list
        entries.Clear();

        // make sure the file exists
        if (!File.Exists(fileName))
        {
            Console.WriteLine($"Sorry. {fileName} does not exist.");
            return;
        }

        // read each line in the file
        string[] lines = File.ReadAllLines(fileName);

        // loop through the lines
        foreach (string line in lines)
        {
            // split the lines by the predetermined delimiter
            string[] parts = line.Split("|~|");

            // create a new entry object
            Entry entry = new Entry();

            // store the date
            entry.date = DateTime.Parse(parts[0]);

            // store the prompt
            entry.prompt = parts[1];

            // store the response
            entry.response = parts[2];

            // add the current entry object to the Journal's entries list.
            entries.Add(entry);

        }

        // success message
        Console.WriteLine($"Loaded {entries.Count} entries from {fileName}");




    }



}