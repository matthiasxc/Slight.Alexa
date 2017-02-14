using Newtonsoft.Json;
using Slight.Alexa.Framework.Models.Responses.DirectiveTypes;
using System.Collections.Generic;

namespace Slight.Alexa.Framework.Models.Responses
{
    public class Response
    {
        /// <summary>
        /// The object containing the speech to render to the user
        /// </summary>
        [JsonProperty("outputSpeech", NullValueHandling = NullValueHandling.Ignore)]
        public IOutputSpeech OutputSpeech { get; set; }

        /// <summary>
        /// The object containing a card to render to the Amazon Alexa App. 
        /// </summary>
        [JsonProperty("card", NullValueHandling = NullValueHandling.Ignore)]
        public ICard Card { get; set; }

        /// <summary>
        /// The object containing the outputSpeech to use if a re-prompt is necessary.
        /// 
        /// This is used if the your service keeps the session open after 
        /// sending the response, but the user does not respond with anything 
        /// that maps to an intent defined in your voice interface while the audio 
        /// stream is open.
        /// 
        /// If this is not set, the user is not re-prompted.
        /// </summary>
        [JsonProperty("reprompt", NullValueHandling = NullValueHandling.Ignore)]
        public Reprompt Reprompt { get; set; }

        /// <summary>
        /// A boolean value with true meaning that the session should end, 
        /// or false if the session should remain active.
        /// </summary>
        [JsonProperty("shouldEndSession", NullValueHandling = NullValueHandling.Ignore)]
        public bool ShouldEndSession { get; set; }

        /// <summary>
        /// An array of directives specifying device-level actions to take 
        /// using a particular interface, such as the AudioPlayer interface 
        /// for streaming audio
        /// </summary>
        [JsonProperty("directives", NullValueHandling = NullValueHandling.Ignore)]
        public List<IDirective> Directives { get; set; }


        }
}

//{
//  "version": "string",
//  "sessionAttributes": {
//    "string": object
//  },
//  "response": {
//    "outputSpeech": {
//      "type": "string",
//      "text": "string",
//      "ssml": "string"
//    },
//    "card": {
//      "type": "string",
//      "title": "string",
//      "content": "string",
//      "text": "string",
//      "image": {
//        "smallImageUrl": "string",
//        "largeImageUrl": "string"
//      }
//    },
//    "reprompt": {
//      "outputSpeech": {
//        "type": "string",
//        "text": "string",
//        "ssml": "string"
//      }
//    },
//    "directives": [
//      {
//        "type": "string",
//        "playBehavior": "string",
//        "audioItem": {
//          "stream": {
//            "token": "string",
//            "url": "string",
//            "offsetInMilliseconds": 0
//          }
//        }
//      }
//    ],
//    "shouldEndSession": boolean
//  }
//}