   // Get current date and time
    DateTime now = DateTime.Now;
    
    // Create a specific date and time
    DateTime specificDate = new DateTime(2023, 5, 1, 10, 0, 0);
    
    // Get year, month, day, hour, minute, second
    int year = now.Year;
    int month = now.Month;
    int day = now.Day;
    int hour = now.Hour;
    int minute = now.Minute;
    int second = now.Second;
    
    // Add or subtract time intervals
    DateTime later = now.AddDays(7);
    DateTime earlier = now.AddHours(-3);
    
    // Format date and time
    string formatted = now.ToString("MM/dd/yyyy HH:mm:ss");
    
    // Compare dates
    bool isBefore = specificDate < now;
    bool isAfter = specificDate > now;
    bool isEqual = specificDate == now;
    
    // Get time span between two dates
    TimeSpan span = specificDate - now;
    double daysBetween = span.TotalDays;
    
    // Convert string to date
    string dateString = "2023-05-01";
    DateTime dateFromString = DateTime.Parse(dateString);
    
    // Convert date to string with custom format
    string formattedDate = specificDate.ToString("dddd, MMMM d yyyy");
    
    // Get first day of month
    DateTime firstDayOfMonth = new DateTime(now.Year, now.Month, 1);
    
    // Get last day of month
    DateTime lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);
    
    // Get number of days in month
    int daysInMonth = DateTime.DaysInMonth(now.Year, now.Month);
    
    // Get day of week
    DayOfWeek dayOfWeek = specificDate.DayOfWeek;
    
    // Check if year is a leap year
    bool isLeapYear = DateTime.IsLeapYear(now.Year);
    