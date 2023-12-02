public class OutdoorEvent: Event
{
  // Outdoor gatherings, which do not have a limit on attendees, but need to track the weather forecast.  
   public OutdoorEvent(string title,string description,string date,int time,Address address):base(title,description,date,time,address)
    {
        _type = "Outdoors";
    }
}