public class OutdoorEvent: Event
{
  // Outdoor gatherings, which do not have a limit on attendees, but need to track the weather forecast.  
   public OutdoorEvent(string title,string description,string date,int time,Address address,string weather):base(title,description,date,time,address)
    {
        _type = "Outdoors Gatherings";
         _fullDetails = _standarDetails + @$"
Type of Event: {_type}
Weather: {weather}";
    }
}