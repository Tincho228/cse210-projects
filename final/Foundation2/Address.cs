public class Address
{
    // The address contains a string for the street address, the city, state/province, and country.
    private string _street;
    private string _city;
    private string _state;
    private string _province;
    private string _country;

    public Address(string street, string city, string state, string province, string country){
        _street = street;
        _city = city;
        _state = state;
        _province = province;
        _country = country;
    }

    // The address should have a method that can return whether it is in the USA or not.
    public bool LiveInUsa()
    {
        return (_country == "USA") ? true : false; 
    }

    // The address should have a method to return a string all of its fields together in one string
    // (with newline characters where appropriate)
    public string GetAddressFields(){
        string fields = $"Street: {_street}\n         City: {_city}\n         State: {_state}\n         Province: {_province}\n         Country: {_country}";
        return fields;
    }
}