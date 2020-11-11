using Newtonsoft.Json.Linq;
using System.Globalization;

namespace randomuser
{
    public class Dob
    {

        public string Date { get; }
        public int Age { get; }

        public Dob(JToken dobData)
        {
            if (dobData is null)
                throw new System.ArgumentNullException(nameof(dobData));

            Date = dobData.SelectToken("date").ToString();
            Age = int.Parse(dobData.SelectToken("age").ToString(), CultureInfo.InvariantCulture);
        }
        public override string ToString()
        {
            return $"\n\tDate: {Date}\n\tAge: {Age}";
        }
    }
}
