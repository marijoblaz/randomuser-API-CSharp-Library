using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace randomuser
{
    public class Query
    {
        public List<Results> Results { get; } = new List<Results>();
        public Info Info { get; set; }

        public Query()
        {
            ParseQuery("");
        }
        public Query(string parameters)
        {
            ParseQuery(parameters);
        }

        private void ParseQuery(string parameters)
        {
            JObject jsonData;
            using (var client = new System.Net.WebClient())
                jsonData = JObject.Parse(client.DownloadString($"https://randomuser.me/api/?{parameters}"));

            foreach (JToken results in jsonData.SelectToken("results"))
                Results.Add(new Results(results));
            Info = new Info(jsonData.SelectToken("info"));
        }
    }
}
