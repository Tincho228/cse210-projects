public class LecturesEvent:Event
{
    // Lectures, which have a speaker and have a limited capacity.

    public LecturesEvent(string title,string description,string date,int time,Address address,string speaker,int capacity):base(title,description,date,time,address)
    {
        _type = "Lectures";
        _fullDetails = _standarDetails + @$"
Type of Event: {_type}
Speaker name:{speaker}
Capacity: {capacity}";

    }
}