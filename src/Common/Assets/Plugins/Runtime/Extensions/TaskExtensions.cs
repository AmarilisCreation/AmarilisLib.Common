using System.Threading.Tasks;

namespace AmarilisLib
{
    public static partial class TaskExtensions
    {
        /// <summary>
        /// Forgets the given task without waiting for its completion.
        /// </summary>
        /// <param name="task">The task to forget.</param>
        public static void Forget(this Task task) => task.ConfigureAwait(true);
        /// <summary>
        /// Forgets the given task without waiting for its completion.
        /// </summary>
        /// <typeparam name="T">The type of the result produced by the task.</typeparam>
        /// <param name="task">The task to forget.</param>
        public static void Forget<T>(this Task<T> task) => task.ConfigureAwait(true);
        /// <summary>
        /// Forgets the given task without waiting for its completion and runs it on the ThreadPool.
        /// </summary>
        /// <param name="task">The task to forget.</param>
        public static void ForgetThreadPool(this Task task) => Task.Run(async () => await task.ConfigureAwait(false));
        /// <summary>
        /// Forgets the given task without waiting for its completion and runs it on the ThreadPool.
        /// </summary>
        /// <typeparam name="T">The type of the result produced by the task.</typeparam>
        /// <param name="task">The task to forget.</param>
        public static void ForgetThreadPool<T>(this Task<T> task) => Task.Run(async () => await task.ConfigureAwait(false));
    }
}