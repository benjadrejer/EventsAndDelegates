using System;
using System.Threading;

namespace EventsAndDelegates
{
    public class VideoEncoder
    {
        public delegate void VideoEncoderEventHandler(object obj, Video e);

        public event VideoEncoderEventHandler VideoIsEncoded;

        public void EncodeVideo(Video video)
        {
            Console.WriteLine("Encoding Video with title: " + video.Title + "...");
            Thread.Sleep(3000);

            VideoIsEncoded(this, video);
        }

    }
}
