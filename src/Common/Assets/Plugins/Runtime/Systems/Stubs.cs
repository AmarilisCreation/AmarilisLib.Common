using System;

namespace AmarilisLib
{
    /// <summary>
    /// A utility class providing common stubs for various use cases, such as 
    /// no-operation actions, exception throwing, and parameter ignoring.
    /// </summary>
    public class Stubs
    {
        /// <summary>
        /// Represents a no-operation action that performs no work when executed.
        /// </summary>
        public static readonly Action Nop = () => { };

        /// <summary>
        /// Represents an action that throws the provided exception when executed.
        /// </summary>
        /// <param name="ex">The exception to be thrown.</param>
        public static readonly Action<Exception> Throw = ex => { throw ex; };

        /// <summary>
        /// Ignores the specified parameter without performing any operation on it.
        /// This can be useful for suppressing compiler warnings about unused parameters.
        /// </summary>
        /// <typeparam name="T">The type of the parameter to ignore.</typeparam>
        /// <param name="t">The parameter to ignore.</param>
        public static void Ignore<T>(T t) { }
    }
}
