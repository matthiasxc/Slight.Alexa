using System;
using System.Collections.Generic;
using System.Text;

namespace Slight.Alexa.Framework.Models.Requests.RequestTypes
{
    public interface IAudioRequest : IRequest
    {
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

    //  AudioPlayer.PlaybackFailed
    //  {
    //    "type": "AudioPlayer.PlaybackFailed",
    //    "requestId": "string",
    //    "timestamp": "string",
    //    "token": "string",
    //    "locale": "string",
    //    "error": {
    //      "type": "string",
    //      "message": "string"
    //    },
    //    "currentPlaybackState": {
    //      "token": "string",
    //      "offsetInMilliseconds": 0,
    //      "playerActivity": "string"
    //    }
    //  }

    // System.ExceptionEncounteredRequest
    //  {
    //    "type": "AudioPlayer.PlaybackFailed",
    //    "requestId": "string",
    //    "timestamp": "string",
    //    "token": "string",
    //    "locale": "string",
    //    "error": {
    //      "type": "string",
    //      "message": "string"
    //    },
    //    "currentPlaybackState": {
    //      "token": "string",
    //      "offsetInMilliseconds": 0,
    //      "playerActivity": "string"
    //    }
    //  }


}
