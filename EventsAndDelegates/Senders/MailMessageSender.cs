using System;

namespace EventsAndDelegates
{
    public class MailMessageSender
    {
        public void OnVideoEncoded(object obj, Video e)
        {
            Console.WriteLine("Sending Mail to customer: " + e.Title + " was successfully encoded!" +
                " Postage fee equals " + e.PostageCost + "$");
        }
    }
}
