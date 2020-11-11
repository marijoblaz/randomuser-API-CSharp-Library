using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace randomuser
{
    public class Street
    {
        public int Number { get; }
        public string Name { get; }

        public Street(JToken streetData)
        {
            if (streetData is null)
                throw new System.ArgumentNullException(nameof(streetData));

            Number = int.Parse(streetData.SelectToken("number").ToString(), CultureInfo.InvariantCulture);
            Name = streetData.SelectToken("name").ToString();
        }
        public override string ToString()
        {
            return $"\n\t\tNumber: {Number}\n\t\tName: {Name}";
        }
    }
}
