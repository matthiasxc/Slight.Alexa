using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Slight.Alexa.Framework.Models.Responses.DirectiveTypes
{
    public interface IPlayDirective : IDirective
    {
        [JsonRequired]
        [JsonProperty("playBehavior")]
        string PlayBehavior { get; set; }

        [JsonRequired]
        [JsonProperty("audioItem")]
        AudioItem AudioItem { get; set; }
    }
    //  PlayBehavior
    //  Describes playback behavior. Accepted values:
    //      REPLACE_ALL: Immediately begin playback of the specified stream, and replace current and enqueued streams.
    //      ENQUEUE: Add the specified stream to the end of the current queue.This does not impact the currently playing stream.
    //      REPLACE_ENQUEUED: Replace all streams in the queue. This does not impact the currently playing stream.


    //  AudioPlayer.Play - Sends Alexa a command to stream the audio file identified by the specified audioItem.
    //      {
    //        "type": "AudioPlayer.Play",
    //        "playBehavior": "string",
    //        "audioItem": {
    //          "stream": {
    //            "url": "string",
    //            "token": "string",
    //            "expectedPreviousToken": "string",
    //            "offsetInMilliseconds": 0
    //          }
    //        }
    //      }
}
