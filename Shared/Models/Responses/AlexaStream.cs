using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Slight.Alexa.Framework.Models.Responses
{
    public class AlexaStream
    {
        [JsonRequired]
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonRequired]
        [JsonProperty("token")]
        public string Token { get; set; }

        // only use this with the behavior is ENQUEUE to let them know you know what 
        //  the previous item in the queue is
        [JsonProperty("expectedPreviousToken")]
        public string ExpectedPreviousToken { get; set; }

        [JsonProperty("offsetInMilliseconds")]
        public long OffsetInMilliseconds { get; set; }

    }

    //"stream": {
    //            "url": "string",
    //            "token": "string",
    //            "expectedPreviousToken": "string",
    //            "offsetInMilliseconds": 0
    //          }
}
