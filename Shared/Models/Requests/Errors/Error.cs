using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Slight.Alexa.Framework.Models.Requests.Errors
{
    public class Error
    {
        /// <summary>
        /// audio token
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// audio token
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }

        
    }
}
