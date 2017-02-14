using System;
using System.Collections.Generic;
using System.Text;
using Slight.Alexa.Framework.Models.Requests.Errors;

namespace Slight.Alexa.Framework.Models.Requests.RequestTypes
{
    public interface IAudioError : IAudioRequest
    {
        Error Error { get; set; }
        CurrentPlaybackState CurrentPlaybackState { get; set; }
    }

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
    //    "type": "System.ExceptionEncountered",
    //    "requestId": "string",
    //    "timestamp": "string",
    //    "locale": "string",
    //    "error": {
    //      "type": "string",
    //      "message": "string"
    //    },
    //    "cause": {
    //      "requestId": "string"
    //    }
    //  }
Parame
    //  }
}
