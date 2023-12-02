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

    public string GetAddressFields(){
        string fields = $"Street: {_street}\n         City: {_city}\n         State: {_state}\n         Province: {_province}\n         Country: {_country}";
        return fields;
    }
}