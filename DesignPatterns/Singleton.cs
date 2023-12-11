using System;
using System.Threading;

namespace DesignPatterns
{
    public class Singleton
    {
        private static Singleton Instance;
        private static readonly object ThreadLock = new object();

        public string Value { get; set; }

        private Singleton() {}

        public static Singleton GetInstance(string value)
        {
            if (Instance == null)
            {
                lock (ThreadLock)
                {
                    if (Instance == null)
                    {
                        Instance = new Singleton();
                        Instance.Value = value;
                    }
                }
            }

            return Instance;
        }

    }
}
