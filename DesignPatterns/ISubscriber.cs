using System;

namespace DesignPatterns
{
    /// <summary>
    ///  ISubscriber - Observer
    /// </summary>
    public interface ISubscriber
    {
        string EmailAddress { get; set; }
        string MobileNumber { get; set; }
        void Update(string message);
    }
}
