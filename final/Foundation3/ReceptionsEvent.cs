public class ReceptionsEvent: Event
{
    // Receptions, which require people to RSVP, or register, beforehand.
    public ReceptionsEvent(string title,string description,string date,int time,Address address,string email):base(title,description,date,time,address)
    {
        _type = "Receptions";
        _fullDetails = _standarDetails + @$"
Type of Event: {_type}
Email for RSVP: {email}";
    }
}