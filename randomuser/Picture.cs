using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace randomuser
{
    public class Picture
    {
        public string Large { get;}
        public string Medium { get;}
        public string Thumbnail { get;}

        public Picture(JToken pictureData)
        {
            if (pictureData is null)
                throw new System.ArgumentNullException(nameof(pictureData));

            Large = pictureData.SelectToken("large").ToString();
            Medium = pictureData.SelectToken("medium").ToString();
            Thumbnail = pictureData.SelectToken("thumbnail").ToString();

        }
        public override string ToString()
        {
            return $"\n\tLarge: {Large}\n\tMedium: {Medium}\n\tMedium: {Thumbnail}";
        }

    }
}
