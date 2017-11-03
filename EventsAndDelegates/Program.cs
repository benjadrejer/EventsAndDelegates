using System;

namespace EventsAndDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initial input (throw exception if null or empty)
            Console.WriteLine("Please type the title of the video to be encoded");
            string title = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(title))
                throw new InvalidOperationException("Please do not leave the title empty");

            //New video with hardcoded price
            var video = new Video { Title = title, Price = 9.99m };

            //Instantiate classes
            var videoEncoder = new VideoEncoder();
            var calculator = new Calculator();
            var mailSender = new MailMessageSender();
            var smsSender = new SMSMessageSender();

            Console.WriteLine("Would you like to notify subscribers? (type \"yes\")");
            string answer = Console.ReadLine();

            if(answer == "yes")
            {
                //Subscribe to event VideoIsEncoded
                videoEncoder.VideoIsEncoded += mailSender.OnVideoEncoded;
                videoEncoder.VideoIsEncoded += smsSender.OnVideoEncoded;
            }
            else
            {
                Console.WriteLine("No notifications sent.");
            }


            //Instantiate delegate and add delegate methods to create a multicast delegate
            VideoConfigurations.VideoConfigurator handler = VideoConfigurations.RegionConfigurator;
            handler += VideoConfigurations.BoxColorConfigurator;
            handler += VideoConfigurations.DiscConfigurator;

            //Hardcoding input to delegate methods
            string[] input = { "PAL", "#232323", "Bluray" };

            //Call delegate
            handler(video, input);

            //Calculate postage
            video.PostageCost = calculator.CalculatePostageCost(video.Price);

            //Encode the video (which will trigger the subscribers of the event)
            videoEncoder.EncodeVideo(video);
            
            Console.ReadKey();
        }
    }
}
