
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Slight.Alexa.Framework.Models.Requests
{
    public class System
    {
        /// <summary>
        /// An object containing an application ID. 
        /// </summary>
        [JsonProperty("application")]
        public Application Application { get; set; }

        /// <summary>
        /// An object that describes the user making the request.
        /// </summary>
        [JsonProperty("user")]
        public User User { get; set; }

        /// <summary>
        /// An object to indicate information about the device, including supported interfaces
        /// </summary>
        [JsonProperty("device")]
        public Device Device { get; set; }
        




    }
}
