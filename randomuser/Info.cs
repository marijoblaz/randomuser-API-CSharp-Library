using Newtonsoft.Json.Linq;
using System.Globalization;

namespace randomuser
{
    public class Info
    {
        public string Seed { get; }
        public int Results { get; }
        public int Page { get; }
        public string Version { get; }

        public Info(JToken infoData)
        {
            if (infoData is null)
                throw new System.ArgumentNullException(nameof(infoData));

            Seed = infoData.SelectToken("seed").ToString();
            Results = int.Parse(infoData.SelectToken("results").ToString(), CultureInfo.InvariantCulture);
            Page = int.Parse(infoData.SelectToken("page").ToString(), CultureInfo.InvariantCulture);
            Version = infoData.SelectToken("version").ToString();
        }
        public override string ToString()
        {
            return $"Seed: {Seed}, Results: {Results}, Page: {Page}, Version: {Version}";
        }
    }
}
