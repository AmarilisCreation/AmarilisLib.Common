using System;

namespace AmarilisLib
{
    /// <summary>
    /// Provides support for lazy initialization. Lazy initialization is the
    /// delaying of the creation of an object until it is needed.
    /// </summary>
    /// <typeparam name="T">Specifies the type of object that is being lazily initialized.</typeparam>
    public class Lazy<T>
    {
        private readonly object lockObject = new object();
        private Func<T> _func;
        private T _result;
        private bool _isValueCreated = false;

        /// <summary>
        /// Initializes a new instance of the <see cref="Lazy{T}"/> class with the specified initialization function.
        /// </summary>
        /// <param name="func">The delegate that is invoked to produce the lazily initialized value when it is needed.</param>
        public Lazy(Func<T> func)
        {
            _func = func;
        }

        /// <summary>
        /// Gets the lazily initialized value of the current <see cref="Lazy{T}"/> instance.
        /// </summary>
        public T Value
        {
            get
            {
                lock(lockObject)
                {
                    if(!_isValueCreated)
                    {
                        _isValueCreated = true;
                        _result = _func();
                    }
                }
                return _result;
            }
        }

        /// <summary>
        /// Gets a value that indicates whether a value has been created for this <see cref="Lazy{T}"/> instance.
        /// </summary>
        public bool IsValueCreated { get { return _isValueCreated; } }

        /// <summary>
        /// Creates and returns a string representation of the <see cref="Lazy{T}.Value"/> property for this instance.
        /// </summary>
        /// <returns>The result of calling the <see cref="Object.ToString"/> method on the <see cref="Lazy{T}.Value"/> property for this instance, if the value has been created; otherwise, a string indicating that the value has not been created.</returns>
        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
