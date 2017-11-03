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
            Console.WriteLine("Configuring region to: " + e[0]);
        }

        public static void BoxColorConfigurator(Video video, string[] e)
        {
            Console.WriteLine("Configuring Box color to: " + e[1]);
        }

        public static void DiscConfigurator(Video video, string[] e)
        {
            Console.WriteLine("The type of disc is set to: " + e[2]);
        }
    }

}