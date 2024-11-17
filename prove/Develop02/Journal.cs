
public class Journal
{
    public List<Entry> _entries = new List<Entry>();


    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    // citing me dad, but i can explain what's going on
    public void Save(string filename)
    {   // 'hey write a new file thing ok and while it's open--
        using (StreamWriter outputFile = new StreamWriter(filename))
        {  
             // --save each entry in _entries to the output file
            // using a Save method in Entry because the 
            // Journal's Save method doesn't need to know 
            // everything all the time and neither do i
            foreach (Entry entry in _entries)
            {
                entry.Save(outputFile);
            }
        }
    }
    public void Load(string filename)
    {   // clears the current entries in the entry list so
        // they can be replaced with the loaded content
        _entries.Clear();

        // also inputFile stuff dad says convention reasons
        // WHILE USING this file reader --   
        using (StreamReader inputFile = new StreamReader(filename))
        {   // WHILE there's still a stream, do this stuff:
            while (!inputFile.EndOfStream)
            {   
                // create entry so I can access Entry things
                Entry entry = new Entry();
                // like the new Load method in Entry that counts
                // only three lines at a time, and those three
                // lines make up an entry. fragile? ya, probably, but SIMPLE
                entry.Load(inputFile);
                // add the three lines and do AddEntry AND DON'T 
                // THINK ABOUT HOW IT DOES IT OR ELSE I'LL GO 
                // INSANE
                AddEntry(entry);
            }
        }
    }
}