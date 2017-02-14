using System;
using System.Collections.Generic;
using System.Text;

namespace Slight.Alexa.Framework.Models.Types
{
    public class AudioError
    {
        /// <summary>
        /// An unknown error occurred.
        /// </summary>
        public const string Unknown = "MEDIA_ERROR_UNKNOWN";

        /// <summary>
        /// Alexa recognized the request as being malformed. E.g. bad request, unauthorized, forbidden, not found, etc.
        /// </summary>
        public const string InvalidRequest = "MEDIA_ERROR_INVALID_REQUEST";

        /// <summary>
        /// Alexa was unable to reach the URL for the stream.
        /// </summary>
        public const string ServiceUnavailable = "MEDIA_ERROR_SERVICE_UNAVAILABLE";

        /// <summary>
        /// Alexa accepted the request, but was unable to process the request as expected.
        /// </summary>
        public const string InternalServerError = "MEDIA_ERROR_INTERNAL_SERVER_ERROR";

        /// <summary>
        /// Indicates nothing was playing and there are no queued items
        /// </summary>
        public const string InternalDeviceError = "MEDIA_ERROR_INTERNAL_DEVICE_ERROR";

        /// <summary>
        /// Indicates nothing was playing and there are no queued items
        /// </summary>
        public const string InvalidResponse = "INVALID_RESPONSE";

        /// <summary>
        /// Indicates nothing was playing and there are no queued items
        /// </summary>
        public const string DeviceCommunicationError = "DEVICE_COMMUNICATION_ERROR";

        /// <summary>
        /// Indicates nothing was playing and there are no queued items
        /// </summary>
        public const string InternalSystemError = "INTERNAL_ERROR";



    }
}
