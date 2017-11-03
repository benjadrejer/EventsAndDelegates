using System;

namespace EventsAndDelegates
{
    public class SMSMessageSender
    {
        public void OnVideoEncoded(object obj, Video e)
        {
            Console.WriteLine("Sending SMS to customer: " + e.Title + " was successfully encoded!" +
                " Postage fee equals " + e.PostageCost + "$");
        }
    }
}
