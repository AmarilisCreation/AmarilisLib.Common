using System;
using System.Collections.Generic;

namespace AmarilisLib
{
    /// <summary>
    /// Provides an equality comparer for objects of type <typeparamref name="T"/> 
    /// based on a key extracted from the object using a lambda expression.
    /// </summary>
    /// <typeparam name="T">The type of objects to compare.</typeparam>
    /// <typeparam name="TKey">The type of the key used for comparison.</typeparam>
    public class LambdaEqualityComparer<T, TKey> : IEqualityComparer<T>
    {
        private readonly Func<T, TKey> _selector;

        /// <summary>
        /// Initializes a new instance of the <see cref="LambdaEqualityComparer{T, TKey}"/> class.
        /// </summary>
        /// <param name="selector">A function to extract the key from an object of type <typeparamref name="T"/>.</param>
        public LambdaEqualityComparer(Func<T, TKey> selector)
        {
            _selector = selector ?? throw new ArgumentNullException(nameof(selector));
        }

        bool IEqualityComparer<T>.Equals(T x, T y)
            => _selector(x).Equals(_selector(y));

        int IEqualityComparer<T>.GetHashCode(T obj)
            => _selector(obj).GetHashCode();
    }
}
