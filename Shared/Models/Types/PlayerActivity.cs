using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Types
{
    public class PlayerActivity
    {
        /// <summary>
        /// Indicates nothing was playing and there are no queued items
        /// </summary>
        public const string Idle = "IDLE";

        /// <summary>
        /// Audio stream is paused
        /// </summary>
        public const string Paused = "PAUSED";

        /// <summary>
        /// Audio stream is playing 
        /// </summary>
        public const string Playing = "PLAYING";

        /// <summary>
        /// buffer underrun indication
        /// </summary>
        public const string BufferUnderrun = "BUFFER_UNDERRUN";

        /// <summary>
        /// Audio stream finished playing
        /// </summary>
        public const string Finished = "FINISHED";

        /// <summary>
        /// Audio stream was interrupted
        /// </summary>
        public const string Stopped = "STOPPED";

        public static AudioStatus AsStatus(string activity)
        {
            AudioStatus status = AudioStatus.Idle;
            switch (activity)
            {
                case PlayerActivity.Idle:
                    status = AudioStatus.Idle;
                    break;
                case PlayerActivity.Playing:
                    status = AudioStatus.Playing;
                    break;
                case PlayerActivity.Paused:
                    status = AudioStatus.Paused;
                    break;
                case PlayerActivity.BufferUnderrun:
                    status = AudioStatus.BufferUnderrun;
                    break;
                case PlayerActivity.Finished:
                    status = AudioStatus.Finished;
                    break;
                case PlayerActivity.Stopped:
                    status = AudioStatus.Stopped;
                    break;
                default:
                    status = AudioStatus.Error;
                    break;
            }
            return status;
        }
    }

    public enum AudioStatus
    {
        Idle,
        Paused,
        Playing, 
        BufferUnderrun,
        Finished, 
        Stopped, 
        Error
    }

}
