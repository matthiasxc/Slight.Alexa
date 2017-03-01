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

}
