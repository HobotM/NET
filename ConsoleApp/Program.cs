
string response;

System.Console.WriteLine("What is your name?");
response = Console.ReadLine();

System.Console.WriteLine("Hello " + response);

OperatingSystem thisOs = Environment.OSVersion;
Console.Write(thisOs.Platform);
Console.Write(thisOs.VersionString);

