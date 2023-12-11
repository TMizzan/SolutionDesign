using System;

namespace DesignPatterns
{
    /// <summary>
    ///  ISubscriber - Observer
    /// </summary>
    public interface ISubscriber
    {
        void Update(string message);
    }
}
