using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    public class VideoConfigurations
    {
        public delegate void VideoConfigurator(Video video, string[] e);

        public static void RegionConfigurator(Video video, string[] e)
        {
            video.Region = e[0];
            Console.WriteLine("Configuring region to: " + video.Region);
        }

        public static void BoxColorConfigurator(Video video, string[] e)
        {
            video.BoxColor = e[1];
            Console.WriteLine("Configuring Box color to: " + video.BoxColor);
        }

        public static void DiscConfigurator(Video video, string[] e)
        {
            video.DiscType = e[2];
            Console.WriteLine("The type of disc is set to: " + video.DiscType);
        }
    }

}