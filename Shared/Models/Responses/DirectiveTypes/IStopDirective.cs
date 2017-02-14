using System;
using System.Collections.Generic;
using System.Text;

namespace Slight.Alexa.Framework.Models.Responses.DirectiveTypes
{
    public interface IStopDirective : IDirective
    {
    }

    //  AudioPlayer.Stop - Stops any currently playing audio stream.
    //      {
    //        "type": "AudioPlayer.Stop"
    //      }
}
