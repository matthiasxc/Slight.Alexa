using System.Collections.Generic;
using Newtonsoft.Json;

namespace Slight.Alexa.Framework.Models.Requests
{
    /// <summary>
    /// The context provides current state of the Alexa service and device at the time
    ///     the request is sent to our service. It is included on all requests
    /// </summary>
    public class Context
    {
        /// <summary>
        /// the System object gives the current state of the services and the device 
        /// </summary>
        /// <returns>System object containing the application id, user id, and AudioPlayer information</returns>
        [JsonProperty("System")]
        public System System { get; set; }

        /// <summary>
        /// AudioPLayer contains information about the state of the skill regarding
        ///     its status and capabilities as an AudioPlayer
        /// </summary>
        /// <returns>token, offset in milliseconds, playeractivity</returns>
        [JsonProperty("AudioPlayer")]
        public AudioPlayer AudioPlayer { get; set; }

    }
}
