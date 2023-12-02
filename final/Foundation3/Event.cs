public class Event
{
    //all events need to have an Event Title, Description, Date, Time, and Address.
    private string _title;
    private string _description;
    private string _date;
    private int _time;
    private Address _address;
    protected string _standarDetails;
    protected string _fullDetails;
    protected string _type;

    public Event(string title,string description,string date,int time,Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;

        //Lists the title, description, date, time, and address.
        _standarDetails = @$"Title: {_title}.
Description: {_description}.
Date: {_date}.
Time: {_time} hrs.
Address: {_address.GetAddressFields()}";
    }
    
    public string StandardDetails()
    {
        PrintLine();
        ConsoleColor blue = ConsoleColor.Blue;
        Console.ForegroundColor = blue;
        Console.WriteLine("Standard Details");
        Console.ResetColor();
        PrintLine();
        return _standarDetails;
    }

    public string FullDetails()
    {
        // Lists all of the above, plus type of event and information specific to that event type.
        // For lectures, this includes the speaker name and capacity. 
        // For receptions this includes an email for RSVP. For outdoor gatherings, this includes a 
        // statement of the weather.
        PrintLine();
        ConsoleColor yellow = ConsoleColor.Yellow;
        Console.ForegroundColor = yellow;
        Console.WriteLine("Full Details");
        Console.ResetColor();
        PrintLine();
        return _fullDetails;
    }

    public string ShortDescription()
    {
        // Lists the type of event, title, and the date.
        PrintLine();
        ConsoleColor green = ConsoleColor.Green;
        Console.ForegroundColor = green;
        Console.WriteLine("Short Description");
        Console.ResetColor();
        PrintLine();
        string shortDescription = @$"Type of Event: {_type}
Title: {_title}
Date: {_date}";
        return shortDescription;
    }

    public void PrintLine()
    {
        Console.WriteLine(new string('-', 73));
    }
}