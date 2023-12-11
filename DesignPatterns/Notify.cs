using System;
using System.Collections;
using System.Collections.Generic;

namespace DesignPatterns
{
    /// <summary>
    ///    Notify - Concrete Subject
    /// </summary>
    public class Notify : INotify
    {
        private string Message { get; set; }
        private System.Collections.Generic.List<ISubscriber> Subscribers = new System.Collections.Generic.List<ISubscriber>();

        #region "Constructors"

        public Notify(System.Collections.Generic.List<ISubscriber> subscribers)
        {
            Subscribers = subscribers;
        }

        #endregion

        #region "Public Methods"

        public void Attach(ISubscriber subscriber)
        {
            Subscribers.Add(subscriber);
        }

        public void Detach(ISubscriber subscriber)
        {
            Subscribers.Remove(subscriber);
        }

        public void SendNotication(string message)
        {
            Message = message;

            foreach (ISubscriber subscriber in Subscribers)
            {
                subscriber.Update(Message);
            }
        }

        #endregion
    }
}
