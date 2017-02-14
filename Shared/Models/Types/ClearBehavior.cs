using System;
using System.Collections.Generic;
using System.Text;

namespace Slight.Alexa.Framework.Models.Types
{
    /// <summary>
    /// Clear behaviors are part of the IClearQueueDirective
    ///     an IClearQueueDirective must have a Clear Behavior, which 
    ///     describes how the queue is to be cleared
    /// </summary>
    public class ClearBehavior
    {
        /// <summary>
        /// CLEAR_ENQUEUED
        /// 
        ///     clears the queue, but continues the currently playing item
        /// </summary>
        public const string ClearEnqueued = "CLEAR_ENQUEUED";

        // <summary>
        /// ENQUEUE
        /// 
        ///     clears the queue and stops the current item
        /// </summary>
        public const string ClearAll = "CLEAR_ALL";
    }
}
