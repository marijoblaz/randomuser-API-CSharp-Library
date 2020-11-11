using Newtonsoft.Json.Linq;

namespace randomuser
{
    public class Name
    {
        public string Title { get;}
        public string First { get;}
        public string Last { get;}

        public Name(JToken nameData)
        {
            if (nameData is null)
                throw new System.ArgumentNullException(nameof(nameData));

            Title = nameData.SelectToken("title").ToString();
            First = nameData.SelectToken("first").ToString();
            Last = nameData.SelectToken("last").ToString();

        }
        public override string ToString()
        {
            return $"\n\tTitle: {Title}\n\tFirst: {First}\n\tLast: {Last}";
        }
    }
}
