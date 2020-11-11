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
            parseQuery("");

        }
        public Query(string customQueryRequest)
        {
            parseQuery(customQueryRequest);
        }

        private void parseQuery(string request)
        {
            JObject jsonData;
            using (var client = new System.Net.WebClient())
                jsonData = JObject.Parse(client.DownloadString($"https://randomuser.me/api/?{request}"));

            foreach (JToken results in jsonData.SelectToken("results"))
                Results.Add(new Results(results));
            Info = new Info(jsonData.SelectToken("info"));
        }
    }
}
