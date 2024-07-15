using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace AmarilisLib
{
    public static partial class GenericExtensions
    {
        /// <summary>
        /// Creates a deep copy of the given object using binary serialization.
        /// </summary>
        /// <typeparam name="T">The type of the object to copy.</typeparam>
        /// <param name="src">The object to copy.</param>
        /// <returns>A deep copy of the object.</returns>
        /// <exception cref="SerializationException">Thrown if the object is not serializable.</exception>
        /// <exception cref="ArgumentNullException">Thrown if the source object is null.</exception>
        public static T DeepCopy<T>(this T source)
        {
            using(MemoryStream stream = new MemoryStream())
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(stream, source);
                stream.Position = 0;

                return (T)formatter.Deserialize(stream);
            }
        }
        /// <summary>
        /// Determines whether the specified object is null.
        /// </summary>
        /// <typeparam name="T">The type of the object.</typeparam>
        /// <param name="obj">The object to check for null.</param>
        /// <returns>true if the object is null; otherwise, false.</returns>
        public static bool IsNull<T>(this T obj) where T : class => obj == null;
        /// <summary>
        /// Returns the specified default value if the object is null; otherwise, returns the object.
        /// </summary>
        /// <typeparam name="T">The type of the object.</typeparam>
        /// <param name="obj">The object to check for null.</param>
        /// <param name="defaultValue">The default value to return if the object is null.</param>
        /// <returns>The object if it is not null; otherwise, the specified default value.</returns>
        public static T DefaultIfNull<T>(this T obj, T defaultValue) where T : class => obj ?? defaultValue;
    }
}