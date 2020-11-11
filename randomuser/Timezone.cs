using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace randomuser
{
    public class Timezone
    {
        public string Offset { get; }
        public string Description { get; }

        public Timezone(JToken timezoneData)
        {
            if (timezoneData is null)
                throw new System.ArgumentNullException(nameof(timezoneData));

            Offset = timezoneData.SelectToken("offset").ToString();
            Description = timezoneData.SelectToken("description").ToString();
        }
        public override string ToString()
        {
            return $"\n\t\tOffset: {Offset}\n\t\tDescription: {Description}";
        }
    }
}
