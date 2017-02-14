using System;
using System.Collections.Generic;
using System.Text;

namespace Slight.Alexa.Framework.Models.Requests.RequestTypes
{
    public interface IAudioRequest : IRequest
    {
        string Token { get; set; }
        long OffsetInMilliseconds { get; set; }

    }
    //https://developer.amazon.com/public/solutions/alexa/alexa-skills-kit/docs/custom-audioplayer-interface-reference#playbacknearlyfinished

    //  AudioPlayer.PlaybackStarted
    //  {
    //    "type": "AudioPlayer.PlaybackStarted",
    //    "requestId": "string",
    //    "timestamp": "string",
    //    "token": "string",
    //    "offsetInMilliseconds": 0,
    //    "locale": "string"
    //  }

    //  AudioPlayer.PlaybackFinished
    //  {
    //    "type": "AudioPlayer.PlaybackFinished",
    //    "requestId": "string",
    //    "timestamp": "string",
    //    "token": "string",
    //    "offsetInMilliseconds": 0,
    //    "locale": "string"
    //  }

    //  AudioPlayer.PlaybackStopped 
    //  {
    //    "type": "AudioPlayer.PlaybackStopped",
    //    "requestId": "string",
    //    "timestamp": "string",
    //    "token": "string",
    //    "offsetInMilliseconds": 0,
    //    "locale": "string"
    //  }

    //  AudioPlayer.PlaybackNearlyFinished
    //  {
    //    "type": "AudioPlayer.PlaybackNearlyFinished",
    //    "requestId": "string",
    //    "timestamp": "string",
    //    "token": "string",
    //    "offsetInMilliseconds": 0,
    //    "locale": "string"
    //  }

    


}
