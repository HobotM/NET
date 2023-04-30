string date = "";
DateTime today = DateTime.Today;

do {
    // print the greeting message
    System.Console.WriteLine("Which date? (or 'exit')");
    date = Console.ReadLine();
    
    // if user enters exit the exit the app
    if (date == "exit")
    break;
    
    DateTime parsedDate;
    TimeSpan ts;
    if (DateTime.TryParse(date, out parsedDate)) {
        if (parsedDate < today)
        {
            ts = today - parsedDate;
            System.Console.WriteLine($"That date went by {ts.Days} days ago!");
        }
        else if (parsedDate == today)
        {
            System.Console.WriteLine("That day is today!");

        }
        // not happend yet
        else {
            ts = parsedDate - today;
            System.Console.WriteLine($"That date will be in {ts.Days} days!");
        }


    }
    else {
        System.Console.WriteLine("Invalid format");
    }
} while (date != "exit");