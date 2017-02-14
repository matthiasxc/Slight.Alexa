using System.Collections.Generic;
using Newtonsoft.Json;

namespace Slight.Alexa.Framework.Models.Responses.DirectiveTypes
{
    public interface IDirective
    {
        /// <summary>
        /// Describes the request type with the value as:
        /// IPlayDirective, IStopDirective, IClearQueueDirective
        /// </summary>
        [JsonRequired]
        string Type { get; set;  }

    }

    // Docs: https://developer.amazon.com/public/solutions/alexa/alexa-skills-kit/docs/custom-audioplayer-interface-reference#playbacknearlyfinished
    // Directives - Objects our skill sends back to Alexa
    //  Play
    //  Stop
    //  ClearQueue

    // Intents  - user can invoke intents, which will be sent to your skill
    //  AMAZON.CancelIntent
    //  AMAZON.LoopOffIntent
    //  AMAZON.LoopOnIntent
    //  AMAZON.NextIntent
    //  AMAZON.PauseIntent
    //  AMAZON.PreviousIntent
    //  AMAZON.RepeatIntent
    //  AMAZON.ResumeIntent
    //  AMAZON.ShuffleOffIntent
    //  AMAZON.ShuffleOnIntent
    //  AMAZON.StartOverIntent
    //
    // Requests - an alert from Alexa to tell our skill about changes
    //  AudioPlayer.PlaybackStarted
    //  AudioPlayer.PlaybackFinished 
    //  AudioPlayer.PlaybackStopped 
    //  AudioPlayer.PlaybackNearlyFinished
    //  AudioPlayer.PlaybackFailed

    // PLayback state (part of the 







    //"directives": [
    //  {
    //    "type": "AudioPlayer.Play", - required
    //    "playBehavior": "string", - required
    //    "audioItem": {
    //      "stream": {
    //        "token": "string",
    //        "url": "string",
    //        "offsetInMilliseconds": 0
    //      }
    //    }
    //  }

    //  "type": "AudioPlayer.Play",
    //  "playBehavior": "string",
    //  "audioItem": {
    //    "stream": {
    //      "url": "string",
    //      "token": "string",
    //      "expectedPreviousToken": "string",
    //      "offsetInMilliseconds": 0
    //    }
    //  }
}
