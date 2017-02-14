using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Slight.Alexa.Framework.Models.Responses
{
    public class AudioItem
    {
        [JsonRequired]
        [JsonProperty("stream")]
        public AlexaStream Stream { get; set; }
    }

    //      "audioItem": {
    //          "stream": {
    //            "url": "string",
    //            "token": "string",
    //            "expectedPreviousToken": "string",
    //            "offsetInMilliseconds": 0
    //          }
    //        }
}
