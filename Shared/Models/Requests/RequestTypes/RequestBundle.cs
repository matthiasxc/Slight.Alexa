using Newtonsoft.Json;
using Slight.Alexa.Framework.Models.Requests.Errors;
using System;

namespace Slight.Alexa.Framework.Models.Requests.RequestTypes
{
    public class RequestBundle : IIntentRequest, ILaunchRequest, ISessionEndedRequest, IAudioRequest, IAudioError, ISystemError
    {
        /// <summary>
        /// Describes the request type with the value as:
        /// LaunchRequest, IntentRequest, or SessionEndedRequest
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Represents a unique identifier for the specific request.
        /// </summary>
        [JsonProperty("requestId")]
        public string RequestId { get; set; }

        /// <summary>
        /// Provides the date and time when Alexa sent the request. 
        /// Use this to verify that the request is current and not 
        /// part of a “replay” attack. Timestamp is provided as an 
        /// ISO 8601 formatted string (for example, 2015-05-13T12:34:56Z).
        /// </summary>
        [JsonProperty("timestamp")]
        public DateTime Timestamp { get; set; }

        /// <summary>
        /// Provides the language-region information that we'll need if we 
        /// are going to localize our skill
        /// </summary>
        [JsonProperty("locale")]
        public string Locale { get; set; }

        /// <summary>
        /// An object that represents what the user wants.
        /// </summary>
        [JsonProperty("intent")]
        public Intent Intent { get; set; }

        /// <summary>
        /// Describes why the session ended. Possible values:
        /// 
        /// - USER_INITIATED - The user explicitly ended the session.
        /// - ERROR - An error occurred that caused the session to end.
        /// - EXCEEDED_MAX_REPROMPTS - The user either did not respond or 
        ///   responded with an utterance that did not match any of the intents 
        ///   defined in your voice interface.
        /// </summary>
        [JsonProperty("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// audio token
        /// </summary>
        [JsonProperty("token")]
        public string Token { get; set; }

        /// <summary>
        /// audio offset
        /// </summary>
        [JsonProperty("offsetInMilliseconds")]
        public long OffsetInMilliseconds { get; set; }

        /// <summary>
        /// audio error
        /// </summary>
        [JsonProperty("error")]
        public Error Error { get; set; }

        /// <summary>
        /// current playback state
        /// </summary>
        [JsonProperty("currentPlaybackState")]
        public CurrentPlaybackState CurrentPlaybackState { get; set; }

        /// <summary>
        /// current playback state
        /// </summary>
        [JsonProperty("cause")]
        public Cause Cause{ get; set; }

        public Type GetRequestType()
        {
            switch (Type)
            {
                case "IntentRequest":
                    return typeof(IIntentRequest);
                case "LaunchRequest":
                    return typeof(ILaunchRequest);
                case "SessionEndedRequest":
                    return typeof(ISessionEndedRequest);
                case "AudioPlayer.PlaybackStarted":
                    return typeof(IAudioRequest);
                case "AudioPlayer.PlaybackFinished":
                    return typeof(IAudioRequest);
                case "AudioPlayer.PlaybackStopped":
                    return typeof(IAudioRequest);
                case "AudioPlayer.PlaybackNearlyFinished":
                    return typeof(IAudioRequest);
                case "AudioPlayer.PlaybackFailed":
                    return typeof(IAudioError);
                case "System.ExceptionEncountered":
                    return typeof(ISystemError);
                default:
                    throw new ArgumentOutOfRangeException(nameof(Type), $"Unknown request type: {Type}.");
            }
        }
    }
}