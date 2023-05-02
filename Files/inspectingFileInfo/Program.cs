const string filename = "Text.txt";

if (!File.Exists(filename)) {
    using (StreamWriter sw = File.CreateText(filename))
    {
        sw.WriteLine("This is a text file");
    }
}

// Get some info about txt file

// System.Console.WriteLine(File.GetCreationTime(filename));
// System.Console.WriteLine(File.GetAttributes(filename));  
// System.Console.WriteLine(File.GetLastAccessTime(filename));  
// File.SetAttributes(filename, FileAttributes.ReadOnly);
// System.Console.WriteLine(File.GetAttributes(filename));


// get general info using fileinfo

// try {

//     FileInfo fi = new FileInfo(filename);
//     System.Console.WriteLine($"{fi.Length} bytes"); 
//     System.Console.WriteLine($"{fi.Attributes}"); 
//     System.Console.WriteLine($"{fi.FullName}"); 
//     System.Console.WriteLine($"{fi.Directory}");
//     System.Console.WriteLine($"{fi.IsReadOnly}"); 
// }catch(Exception e) {
//     System.Console.WriteLine($"Exception: {e}");
// }


// manipulate files

DateTime dt = new DateTime(2020, 1, 1);

File.SetCreationTime(filename, dt);

System.Console.WriteLine(File.GetCreationTime(filename));