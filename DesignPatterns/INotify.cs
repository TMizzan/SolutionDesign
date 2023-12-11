using System;

namespace DesignPatterns
{
    /// <summary>
    ///    INotify - Subject
    /// </summary>
    public interface INotify
    {
        void Attach(ISubscriber subscriber);
        void Detach(ISubscriber subscriber);
        void SendNotication(string message);
    }
}