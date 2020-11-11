using Newtonsoft.Json.Linq;

namespace randomuser
{
    public class Id
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public Id(JToken idData)
        {
            if (idData is null)
                throw new System.ArgumentNullException(nameof(idData));

            Name = idData.SelectToken("name").ToString();
            Value = idData.SelectToken("value").ToString();
        }
        public override string ToString()
        {
            return $"\n\tName: {Name}\n\tValue: {Value}";
        }
    }
}
