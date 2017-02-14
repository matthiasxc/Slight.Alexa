using System;
using System.Collections.Generic;
using System.Text;

namespace Slight.Alexa.Framework.Models.Types
{
    /// <summary>
    /// Play behaviors are part of the IPlayDirective
    ///     an IPlayDirective must have a play behavior string, which must
    ///     be one of the strings here
    /// </summary>
    public class PlayBehavior
    {
        /// <summary>
        /// REPLACE_ALL
        /// 
        /// Begin playback of the stream specified in the play directive, 
        ///     replaceing all current and queued items 
        /// </summary>
        public const string ReplaceAll = "REPLACE_ALL";

        // <summary>
        /// ENQUEUE
        /// 
        /// Add the stream in this directive to the end of the current queue
        /// </summary>
        public const string Enqueue = "ENQUEUE";

        // <summary>
        /// REPLACE_ENQUEUED
        /// 
        /// Replace all the the queued items, but leave the currently playing item alone
        /// </summary>
        public const string ReplaceEnqueued = "REPLACE_ENQUEUED";
    }
}
