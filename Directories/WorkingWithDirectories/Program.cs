const string dir = "Test";

// cre4ate delete
if (!Directory.Exists(dir)) {
    Directory.CreateDirectory(dir);
}
else
{
    Directory.Delete(dir);
}


// // get the path for current dir

 string currpath = Directory.GetCurrentDirectory();

// System.Console.WriteLine($"Current directory is {currpath}");

//info about dir
// DirectoryInfo di = new DirectoryInfo(currpath);
// System.Console.WriteLine($"{di.Name}");
// System.Console.WriteLine($"{di.CreationTime}");

//enumerate contents in dir
System.Console.WriteLine("Just Directories");
List<string> dirs = new List<string>(Directory.EnumerateDirectories(currpath));
foreach(string dir1 in dirs)
{
    System.Console.WriteLine(dir);

}

System.Console.WriteLine("------------");

System.Console.WriteLine("Just Files");
List<string> files = new List<string>(Directory.EnumerateFiles(currpath));
foreach(string file in files)
{
    System.Console.WriteLine(file);

}

System.Console.WriteLine("------------");

System.Console.WriteLine("All Directory contents");
List<string> alldirs = new List<string>(Directory.EnumerateFileSystemEntries(currpath));
foreach(string dirr in alldirs)
{
    System.Console.WriteLine(dirr);
}

