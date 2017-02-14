using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Slight.Alexa.Framework.Models.Requests.Errors
{
    public class Cause
    {
        /// <summary>
        /// The requestId for the request that caused the error
        /// </summary>
        [JsonProperty("requestId")]
        public string RequestId { get; set; }
    }
}
