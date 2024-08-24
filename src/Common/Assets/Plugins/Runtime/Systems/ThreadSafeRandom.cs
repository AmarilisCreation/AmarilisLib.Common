using System;
using System.Threading;

namespace AmarilisLib
{
    /// <summary>
    /// Provides a thread-safe random number generator using a thread-local instance of <see cref="Random"/>.
    /// </summary>
    public static class ThreadSafeRandom
    {
        private static readonly ThreadLocal<Random> threadLocalRandom =
            new ThreadLocal<Random>(() => new Random(Environment.TickCount * Thread.CurrentThread.ManagedThreadId));

        /// <summary>
        /// Gets a thread-safe instance of <see cref="Random"/> for the current thread.
        /// </summary>
        /// <returns>
        /// A <see cref="Random"/> instance that is unique to the current thread.
        /// </returns>
        public static Random Instance => threadLocalRandom.Value;
    }
}
