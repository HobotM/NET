// Read Write file example

const string filename = "Text.txt";


// overwrites a file with given content

if (!File.Exists(filename))
{
    File.WriteAllText(filename, "new qwe");
}

// Append text 

File.AppendAllText(filename, "text got appended");

// a filestream can be opened and written to until closed

using (StreamWriter sw = File.AppendText(filename))
{
    sw.WriteLine("elo");
    sw.WriteLine("1");
    sw.WriteLine("2");
}