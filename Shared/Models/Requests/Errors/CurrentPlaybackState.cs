using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Slight.Alexa.Framework.Models.Requests.Errors
{
    public class CurrentPlaybackState
    {
        /// <summary>
        /// audio token
        /// </summary>
        [JsonProperty("token")]
        public string Token { get; set; }

        /// <summary>
        /// audio offset
        /// </summary>
        [JsonProperty("offsetInMilliseconds")]
        public long OffsetInMilliseconds { get; set; }

        /// <summary>
        /// defines the current player state (see PlayerActivity in the Types folder)
        /// </summary>
        [JsonProperty("playerActivity")]
        public string PlayerActivity { get; set; }
    }

}
