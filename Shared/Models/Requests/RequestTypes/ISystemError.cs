using Slight.Alexa.Framework.Models.Requests.Errors;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slight.Alexa.Framework.Models.Requests.RequestTypes
{
    public interface ISystemError : IRequest
    {
        Error Error { get; set; }
        Cause Cause { get; set; }
    }

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
}
