using System;
using System.Threading;

namespace EventsAndDelegates
{
    public class VideoEncoder
    {
        //Create custom delegate, to take Video in place of EventArgs
        public delegate void VideoEncoderEventHandler(object obj, Video e);

        //Create Event VideoIsEncoded
        public event VideoEncoderEventHandler VideoIsEncoded;

        public void EncodeVideo(Video video)
        {
            Console.WriteLine("Encoding Video with title: " + video.Title + "...");
            Thread.Sleep(3000);

            if (VideoIsEncoded == null)
                Console.WriteLine("No subscribers detected");
            else
            {
                VideoIsEncoded(this, video);
            }
        }

    }
}
