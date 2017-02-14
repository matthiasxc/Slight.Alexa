using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Slight.Alexa.Framework.Models.Responses.DirectiveTypes
{
    public interface IClearQueueDirective : IDirective
    {
        [JsonRequired]
        [JsonProperty("clearBehavior")]
        string ClearBehavior { get; set; }
    }

    //  AudioPlayer.ClearQueue - Clears the queue of all audio streams.
    //      {
    //        "type": "AudioPlayer.ClearQueue",
    //        "clearBehavior" : "string"
    //      }
    //  CLEAR_ENQUEUED: clears the queue and continues to play the currently playing stream
    //  CLEAR_ALL: clears the entire playback queue and stops the currently playing stream(if applicable).



}
