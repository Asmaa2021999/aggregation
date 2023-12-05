using System.Xml.Linq;
class Address
{
    public string city, state, country;
    public Address(string city, string state, string country)
    {
        if (city != null && state != null && country != null)
        {
            this.city = city;
            this.state = state;
            this.country = country;
        }
        else
        {
            throw new ArgumentException("one of the data cells is empty");
        }

      

    }
}