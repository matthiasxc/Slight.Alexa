using System.Collections.Generic;
using Newtonsoft.Json;

namespace Slight.Alexa.Framework.Models.Requests
{
    public class Device
    {
        /// <summary>
        /// A map of key-value pairs. 
        /// Lists interfaces supported by this skill
        /// If skill is capable of playing audio, this will contain an "AudioPlayer" key
        /// </summary>
        /// <returns>
        /// The key is a string that represents the name of the supported interface
        /// The value is an object that represents the value of the interface
        /// </returns>
        [JsonProperty("supportedInterfaces")]
        public Dictionary<string, object> SupportedInterfaces { get; set; }

    }
}
