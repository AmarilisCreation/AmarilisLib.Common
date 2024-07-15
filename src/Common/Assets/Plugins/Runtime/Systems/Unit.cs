using System;

namespace AmarilisLib
{
    /// <summary>
    /// Represents a unit type, a type that has only one value.
    /// </summary>
    public class Unit : IEquatable<Unit>
    {
        /// <summary>
        /// The single instance of the <see cref="Unit"/> type.
        /// </summary>
        static readonly Unit @default = new Unit();

        /// <summary>
        /// Gets the single instance of the <see cref="Unit"/> type.
        /// </summary>
        public static Unit Default { get { return @default; } }

        /// <summary>
        /// Initializes a new instance of the <see cref="Unit"/> class.
        /// </summary>
        private Unit() { }

        /// <summary>
        /// Determines whether two <see cref="Unit"/> objects are equal.
        /// </summary>
        /// <param name="first">The first <see cref="Unit"/> object.</param>
        /// <param name="second">The second <see cref="Unit"/> object.</param>
        /// <returns>true in all cases.</returns>
        public static bool operator ==(Unit first, Unit second) { return true; }

        /// <summary>
        /// Determines whether two <see cref="Unit"/> objects are not equal.
        /// </summary>
        /// <param name="first">The first <see cref="Unit"/> object.</param>
        /// <param name="second">The second <see cref="Unit"/> object.</param>
        /// <returns>false in all cases.</returns>
        public static bool operator !=(Unit first, Unit second) { return false; }

        /// <summary>
        /// Determines whether the specified <see cref="Unit"/> is equal to the current <see cref="Unit"/>.
        /// </summary>
        /// <param name="other">The <see cref="Unit"/> to compare with the current <see cref="Unit"/>.</param>
        /// <returns>true in all cases.</returns>
        public bool Equals(Unit other) { return true; }

        /// <summary>
        /// Determines whether the specified object is equal to the current <see cref="Unit"/>.
        /// </summary>
        /// <param name="obj">The object to compare with the current <see cref="Unit"/>.</param>
        /// <returns>true if the specified object is a <see cref="Unit"/>; otherwise, false.</returns>
        public override bool Equals(object obj) { return obj is Unit; }

        /// <summary>
        /// Serves as a hash function for the <see cref="Unit"/> type.
        /// </summary>
        /// <returns>A hash code for the current <see cref="Unit"/>.</returns>
        public override int GetHashCode() { return 0; }

        /// <summary>
        /// Returns a string that represents the current <see cref="Unit"/>.
        /// </summary>
        /// <returns>A string that represents the current <see cref="Unit"/>.</returns>
        public override string ToString() { return "()"; }
    }
}
