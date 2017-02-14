using System.Collections.Generic;
using Newtonsoft.Json;

namespace Slight.Alexa.Framework.Models.Responses
{
    public class Image
    {
        /// <summary>
        /// A string containing the url for a small image for the card
        /// </summary>
        [JsonProperty("smallImageUrl", NullValueHandling = NullValueHandling.Ignore)]
        public string SmallImageUrl { get; set; }

        /// <summary>
        /// A string containing the url for a large image for the card
        /// </summary>
        [JsonProperty("largeImageUrl", NullValueHandling = NullValueHandling.Ignore)]
        public string LargeImageUrl { get; set; }
    }
}
