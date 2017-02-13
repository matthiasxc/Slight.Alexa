using System.Collections.Generic;
using Newtonsoft.Json;

namespace Slight.Alexa.Framework.Models.Requests
{
    public class AudioPlayer
    {
        /// <summary>
        /// A string that represents the audio stream being played.
        ///     Must return this toekn when sending the "Play" directive 
        ///     Only sent when the target skill is active (or the last audio player)
        /// </summary>
        [JsonProperty("token")]
        public string Token { get; set; }

        /// <summary>
        /// The audio track's current offset in milliseconds at the time the request was sent
        ///     This is 0 if the track is at the beginning
        /// </summary>
        [JsonProperty("offsetInMilliseconds")]
        public long OffsetInMilliseconds { get; set; }

        /// <summary>
        /// A string that represents the audio stream being played.
        ///     Must return this toekn when sending the "Play" directive 
        ///     Only sent when the target skill is active (or the last audio player)
        /// </summary>
        [JsonProperty("playerActivity")]
        public string PlayerActivity { get; set; }
    }
}
