using Newtonsoft.Json.Linq;
using System.Globalization;


namespace randomuser
{
    public class Location
    {
        public Street Street { get; }
        public string City { get; }
        public string State { get; }
        public string Country { get; }
        public string Postcode { get; }
        public Coordinates Coordinates { get; }
        public Timezone Timezone { get; set; }

        public Location(JToken locationData)
        {
            if (locationData is null)
                throw new System.ArgumentNullException(nameof(locationData));

            Street = new Street(locationData.SelectToken("street"));
            City = locationData.SelectToken("city").ToString();
            State = locationData.SelectToken("state").ToString();
            Country = locationData.SelectToken("country").ToString();
            Postcode = locationData.SelectToken("postcode").ToString();
            Coordinates = new Coordinates(locationData.SelectToken("coordinates"));
            Timezone = new Timezone(locationData.SelectToken("timezone"));
        }
        public override string ToString()
        {
            return $"\n\tStreet: {Street}\n\tCity: {City}\n\tState: {State}\n\tCountry: {Country}\n\tPostcode: " +
                   $"{Postcode}\n\tCoordinates: {Coordinates}\n\tTimezone: {Timezone}";
        }
    }
}
