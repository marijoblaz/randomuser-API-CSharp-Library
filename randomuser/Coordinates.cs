using Newtonsoft.Json.Linq;

namespace randomuser
{
    public class Coordinates
    {
        public string Latitude { get; }
        public string Longitude { get; }

        public Coordinates(JToken coordinatesData)
        {
            if (coordinatesData is null)
                throw new System.ArgumentNullException(nameof(coordinatesData));

            Latitude = coordinatesData.SelectToken("latitude").ToString();
            Longitude = coordinatesData.SelectToken("longitude").ToString();

        }
        public override string ToString()
        {
            return $"\n\t\tLatitude: {Latitude}\n\t\tLongitude: {Longitude}";
        }
    }
}
