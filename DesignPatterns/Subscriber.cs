using System;

namespace DesignPatterns
{
    /// <summary>
    ///   Subscriber - Concrete Observer
    /// </summary>
    public class Subscriber : ISubscriber
    {
        public string EmailAddress { get; set; }
        public string MobileNumber { get; set; }

        #region "Constructors"

        public Subscriber(string emailAddress, string mobileNumber)
        {
            EmailAddress = emailAddress;
            MobileNumber = mobileNumber;
        }

        #endregion

        #region "Public Methods"

        public void Update(string message)
        {
            if (!String.IsNullOrEmpty(EmailAddress))
            {
                // TODO: Send Message To Subscriber Using Email API
                Console.WriteLine($"{EmailAddress} Has Been Notified By Email.");
            }

            if (!String.IsNullOrEmpty(MobileNumber))
            {
                // TODO: Send Message To Subscriber Using Text API
                Console.WriteLine($"{MobileNumber} Has Been Notified By Text.");
            }
            return;
        }

        #endregion 
    }
}
