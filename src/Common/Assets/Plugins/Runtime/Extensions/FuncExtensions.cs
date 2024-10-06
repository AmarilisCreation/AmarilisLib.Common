using System;

namespace AmarilisLib
{
    /// <summary>
    /// Provides extension methods for composing multiple <see cref="Func{TResult}"/> delegates.
    /// </summary>
    public static class FuncExtensions
    {
        /// <summary>
        /// Composes two functions where the output of the first function is used as input for the second function.
        /// </summary>
        /// <typeparam name="T1">The type of the input for the first function.</typeparam>
        /// <typeparam name="TResult1">The return type of the first function, which is also the input type for the second function.</typeparam>
        /// <typeparam name="TResult2">The return type of the second function.</typeparam>
        /// <param name="first">The first function to invoke.</param>
        /// <param name="second">The second function to invoke with the result of the first function.</param>
        /// <returns>A composed function that takes an input of type <typeparamref name="T1"/> and returns a result of type <typeparamref name="TResult2"/>.</returns>
        /// <exception cref="ArgumentNullException">Thrown if either <paramref name="first"/> or <paramref name="second"/> is null.</exception>
        public static Func<T1, TResult2> Compose<T1, TResult1, TResult2>(this Func<T1, TResult1> first, Func<TResult1, TResult2> second)
        {
            if(first == null) throw new ArgumentNullException(nameof(first));
            if(second == null) throw new ArgumentNullException(nameof(second));
            return (arg1) => second(first(arg1));
        }

        /// <summary>
        /// Composes two functions with two input parameters.
        /// </summary>
        /// <typeparam name="T1">The type of the first input parameter for the first function.</typeparam>
        /// <typeparam name="T2">The type of the second input parameter for the first function.</typeparam>
        /// <typeparam name="TResult1">The return type of the first function, which is also the input type for the second function.</typeparam>
        /// <typeparam name="TResult2">The return type of the second function.</typeparam>
        /// <param name="first">The first function to invoke.</param>
        /// <param name="second">The second function to invoke with the result of the first function.</param>
        /// <returns>A composed function that takes two inputs of type <typeparamref name="T1"/> and <typeparamref name="T2"/> and returns a result of type <typeparamref name="TResult2"/>.</returns>
        /// <exception cref="ArgumentNullException">Thrown if either <paramref name="first"/> or <paramref name="second"/> is null.</exception>
        public static Func<T1, T2, TResult2> Compose<T1, T2, TResult1, TResult2>(this Func<T1, T2, TResult1> first, Func<TResult1, TResult2> second)
        {
            if(first == null) throw new ArgumentNullException(nameof(first));
            if(second == null) throw new ArgumentNullException(nameof(second));
            return (arg1, arg2) => second(first(arg1, arg2));
        }

        /// <summary>
        /// Composes two functions with three input parameters.
        /// </summary>
        /// <typeparam name="T1">The type of the first input parameter for the first function.</typeparam>
        /// <typeparam name="T2">The type of the second input parameter for the first function.</typeparam>
        /// <typeparam name="T3">The type of the third input parameter for the first function.</typeparam>
        /// <typeparam name="TResult1">The return type of the first function, which is also the input type for the second function.</typeparam>
        /// <typeparam name="TResult2">The return type of the second function.</typeparam>
        /// <param name="first">The first function to invoke.</param>
        /// <param name="second">The second function to invoke with the result of the first function.</param>
        /// <returns>A composed function that takes three inputs of type <typeparamref name="T1"/>, <typeparamref name="T2"/>, and <typeparamref name="T3"/> and returns a result of type <typeparamref name="TResult2"/>.</returns>
        /// <exception cref="ArgumentNullException">Thrown if either <paramref name="first"/> or <paramref name="second"/> is null.</exception>
        public static Func<T1, T2, T3, TResult2> Compose<T1, T2, T3, TResult1, TResult2>(this Func<T1, T2, T3, TResult1> first, Func<TResult1, TResult2> second)
        {
            if(first == null) throw new ArgumentNullException(nameof(first));
            if(second == null) throw new ArgumentNullException(nameof(second));
            return (arg1, arg2, arg3) => second(first(arg1, arg2, arg3));
        }

        /// <summary>
        /// Composes two functions with four input parameters.
        /// </summary>
        /// <typeparam name="T1">The type of the first input parameter for the first function.</typeparam>
        /// <typeparam name="T2">The type of the second input parameter for the first function.</typeparam>
        /// <typeparam name="T3">The type of the third input parameter for the first function.</typeparam>
        /// <typeparam name="T4">The type of the fourth input parameter for the first function.</typeparam>
        /// <typeparam name="TResult1">The return type of the first function, which is also the input type for the second function.</typeparam>
        /// <typeparam name="TResult2">The return type of the second function.</typeparam>
        /// <param name="first">The first function to invoke.</param>
        /// <param name="second">The second function to invoke with the result of the first function.</param>
        /// <returns>A composed function that takes four inputs of type <typeparamref name="T1"/>, <typeparamref name="T2"/>, <typeparamref name="T3"/>, and <typeparamref name="T4"/> and returns a result of type <typeparamref name="TResult2"/>.</returns>
        /// <exception cref="ArgumentNullException">Thrown if either <paramref name="first"/> or <paramref name="second"/> is null.</exception>
        public static Func<T1, T2, T3, T4, TResult2> Compose<T1, T2, T3, T4, TResult1, TResult2>(this Func<T1, T2, T3, T4, TResult1> first, Func<TResult1, TResult2> second)
        {
            if(first == null) throw new ArgumentNullException(nameof(first));
            if(second == null) throw new ArgumentNullException(nameof(second));
            return (arg1, arg2, arg3, arg4) => second(first(arg1, arg2, arg3, arg4));
        }

        /// <summary>
        /// Composes two functions with five input parameters.
        /// </summary>
        /// <typeparam name="T1">The type of the first input parameter for the first function.</typeparam>
        /// <typeparam name="T2">The type of the second input parameter for the first function.</typeparam>
        /// <typeparam name="T3">The type of the third input parameter for the first function.</typeparam>
        /// <typeparam name="T4">The type of the fourth input parameter for the first function.</typeparam>
        /// <typeparam name="T5">The type of the fifth input parameter for the first function.</typeparam>
        /// <typeparam name="TResult1">The return type of the first function, which is also the input type for the second function.</typeparam>
        /// <typeparam name="TResult2">The return type of the second function.</typeparam>
        /// <param name="first">The first function to invoke.</param>
        /// <param name="second">The second function to invoke with the result of the first function.</param>
        /// <returns>A composed function that takes five inputs of type <typeparamref name="T1"/>, <typeparamref name="T2"/>, <typeparamref name="T3"/>, <typeparamref name="T4"/>, and <typeparamref name="T5"/> and returns a result of type <typeparamref name="TResult2"/>.</returns>
        /// <exception cref="ArgumentNullException">Thrown if either <paramref name="first"/> or <paramref name="second"/> is null.</exception>
        public static Func<T1, T2, T3, T4, T5, TResult2> Compose<T1, T2, T3, T4, T5, TResult1, TResult2>(this Func<T1, T2, T3, T4, T5, TResult1> first, Func<TResult1, TResult2> second)
        {
            if(first == null) throw new ArgumentNullException(nameof(first));
            if(second == null) throw new ArgumentNullException(nameof(second));
            return (arg1, arg2, arg3, arg4, arg5) => second(first(arg1, arg2, arg3, arg4, arg5));
        }

        /// <summary>
        /// Composes two functions with six input parameters.
        /// </summary>
        /// <typeparam name="T1">The type of the first input parameter for the first function.</typeparam>
        /// <typeparam name="T2">The type of the second input parameter for the first function.</typeparam>
        /// <typeparam name="T3">The type of the third input parameter for the first function.</typeparam>
        /// <typeparam name="T4">The type of the fourth input parameter for the first function.</typeparam>
        /// <typeparam name="T5">The type of the fifth input parameter for the first function.</typeparam>
        /// <typeparam name="T6">The type of the sixth input parameter for the first function.</typeparam>
        /// <typeparam name="TResult1">The return type of the first function, which is also the input type for the second function.</typeparam>
        /// <typeparam name="TResult2">The return type of the second function.</typeparam>
        /// <param name="first">The first function to invoke.</param>
        /// <param name="second">The second function to invoke with the result of the first function.</param>
        /// <returns>A composed function that takes six inputs of type <typeparamref name="T1"/>, <typeparamref name="T2"/>, <typeparamref name="T3"/>, <typeparamref name="T4"/>, <typeparamref name="T5"/>, and <typeparamref name="T6"/> and returns a result of type <typeparamref name="TResult2"/>.</returns>
        /// <exception cref="ArgumentNullException">Thrown if either <paramref name="first"/> or <paramref name="second"/> is null.</exception>
        public static Func<T1, T2, T3, T4, T5, T6, TResult2> Compose<T1, T2, T3, T4, T5, T6, TResult1, TResult2>(this Func<T1, T2, T3, T4, T5, T6, TResult1> first, Func<TResult1, TResult2> second)
        {
            if(first == null) throw new ArgumentNullException(nameof(first));
            if(second == null) throw new ArgumentNullException(nameof(second));
            return (arg1, arg2, arg3, arg4, arg5, arg6) => second(first(arg1, arg2, arg3, arg4, arg5, arg6));
        }

        /// <summary>
        /// Composes two functions with seven input parameters.
        /// </summary>
        /// <typeparam name="T1">The type of the first input parameter for the first function.</typeparam>
        /// <typeparam name="T2">The type of the second input parameter for the first function.</typeparam>
        /// <typeparam name="T3">The type of the third input parameter for the first function.</typeparam>
        /// <typeparam name="T4">The type of the fourth input parameter for the first function.</typeparam>
        /// <typeparam name="T5">The type of the fifth input parameter for the first function.</typeparam>
        /// <typeparam name="T6">The type of the sixth input parameter for the first function.</typeparam>
        /// <typeparam name="T7">The type of the seventh input parameter for the first function.</typeparam>
        /// <typeparam name="TResult1">The return type of the first function, which is also the input type for the second function.</typeparam>
        /// <typeparam name="TResult2">The return type of the second function.</typeparam>
        /// <param name="first">The first function to invoke.</param>
        /// <param name="second">The second function to invoke with the result of the first function.</param>
        /// <returns>A composed function that takes seven inputs of type <typeparamref name="T1"/>, <typeparamref name="T2"/>, <typeparamref name="T3"/>, <typeparamref name="T4"/>, <typeparamref name="T5"/>, <typeparamref name="T6"/>, and <typeparamref name="T7"/> and returns a result of type <typeparamref name="TResult2"/>.</returns>
        /// <exception cref="ArgumentNullException">Thrown if either <paramref name="first"/> or <paramref name="second"/> is null.</exception>
        public static Func<T1, T2, T3, T4, T5, T6, T7, TResult2> Compose<T1, T2, T3, T4, T5, T6, T7, TResult1, TResult2>(this Func<T1, T2, T3, T4, T5, T6, T7, TResult1> first, Func<TResult1, TResult2> second)
        {
            if(first == null) throw new ArgumentNullException(nameof(first));
            if(second == null) throw new ArgumentNullException(nameof(second));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7) => second(first(arg1, arg2, arg3, arg4, arg5, arg6, arg7));
        }

        /// <summary>
        /// Composes two functions with eight input parameters.
        /// </summary>
        /// <typeparam name="T1">The type of the first input parameter for the first function.</typeparam>
        /// <typeparam name="T2">The type of the second input parameter for the first function.</typeparam>
        /// <typeparam name="T3">The type of the third input parameter for the first function.</typeparam>
        /// <typeparam name="T4">The type of the fourth input parameter for the first function.</typeparam>
        /// <typeparam name="T5">The type of the fifth input parameter for the first function.</typeparam>
        /// <typeparam name="T6">The type of the sixth input parameter for the first function.</typeparam>
        /// <typeparam name="T7">The type of the seventh input parameter for the first function.</typeparam>
        /// <typeparam name="T8">The type of the eighth input parameter for the first function.</typeparam>
        /// <typeparam name="TResult1">The return type of the first function, which is also the input type for the second function.</typeparam>
        /// <typeparam name="TResult2">The return type of the second function.</typeparam>
        /// <param name="first">The first function to invoke.</param>
        /// <param name="second">The second function to invoke with the result of the first function.</param>
        /// <returns>A composed function that takes eight inputs of type <typeparamref name="T1"/>, <typeparamref name="T2"/>, <typeparamref name="T3"/>, <typeparamref name="T4"/>, <typeparamref name="T5"/>, <typeparamref name="T6"/>, <typeparamref name="T7"/>, and <typeparamref name="T8"/> and returns a result of type <typeparamref name="TResult2"/>.</returns>
        /// <exception cref="ArgumentNullException">Thrown if either <paramref name="first"/> or <paramref name="second"/> is null.</exception>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult2> Compose<T1, T2, T3, T4, T5, T6, T7, T8, TResult1, TResult2>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult1> first, Func<TResult1, TResult2> second)
        {
            if(first == null) throw new ArgumentNullException(nameof(first));
            if(second == null) throw new ArgumentNullException(nameof(second));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8) => second(first(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8));
        }

        /// <summary>
        /// Composes two functions with nine input parameters.
        /// </summary>
        /// <typeparam name="T1">The type of the first input parameter for the first function.</typeparam>
        /// <typeparam name="T2">The type of the second input parameter for the first function.</typeparam>
        /// <typeparam name="T3">The type of the third input parameter for the first function.</typeparam>
        /// <typeparam name="T4">The type of the fourth input parameter for the first function.</typeparam>
        /// <typeparam name="T5">The type of the fifth input parameter for the first function.</typeparam>
        /// <typeparam name="T6">The type of the sixth input parameter for the first function.</typeparam>
        /// <typeparam name="T7">The type of the seventh input parameter for the first function.</typeparam>
        /// <typeparam name="T8">The type of the eighth input parameter for the first function.</typeparam>
        /// <typeparam name="T9">The type of the ninth input parameter for the first function.</typeparam>
        /// <typeparam name="TResult1">The return type of the first function, which is also the input type for the second function.</typeparam>
        /// <typeparam name="TResult2">The return type of the second function.</typeparam>
        /// <param name="first">The first function to invoke.</param>
        /// <param name="second">The second function to invoke with the result of the first function.</param>
        /// <returns>A composed function that takes nine inputs of type <typeparamref name="T1"/>, <typeparamref name="T2"/>, <typeparamref name="T3"/>, <typeparamref name="T4"/>, <typeparamref name="T5"/>, <typeparamref name="T6"/>, <typeparamref name="T7"/>, <typeparamref name="T8"/>, and <typeparamref name="T9"/> and returns a result of type <typeparamref name="TResult2"/>.</returns>
        /// <exception cref="ArgumentNullException">Thrown if either <paramref name="first"/> or <paramref name="second"/> is null.</exception>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult2> Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult1, TResult2>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult1> first, Func<TResult1, TResult2> second)
        {
            if(first == null) throw new ArgumentNullException(nameof(first));
            if(second == null) throw new ArgumentNullException(nameof(second));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9) => second(first(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9));
        }

        /// <summary>
        /// Composes two functions with ten input parameters.
        /// </summary>
        /// <typeparam name="T1">The type of the first input parameter for the first function.</typeparam>
        /// <typeparam name="T2">The type of the second input parameter for the first function.</typeparam>
        /// <typeparam name="T3">The type of the third input parameter for the first function.</typeparam>
        /// <typeparam name="T4">The type of the fourth input parameter for the first function.</typeparam>
        /// <typeparam name="T5">The type of the fifth input parameter for the first function.</typeparam>
        /// <typeparam name="T6">The type of the sixth input parameter for the first function.</typeparam>
        /// <typeparam name="T7">The type of the seventh input parameter for the first function.</typeparam>
        /// <typeparam name="T8">The type of the eighth input parameter for the first function.</typeparam>
        /// <typeparam name="T9">The type of the ninth input parameter for the first function.</typeparam>
        /// <typeparam name="T10">The type of the tenth input parameter for the first function.</typeparam>
        /// <typeparam name="TResult1">The return type of the first function, which is also the input type for the second function.</typeparam>
        /// <typeparam name="TResult2">The return type of the second function.</typeparam>
        /// <param name="first">The first function to invoke.</param>
        /// <param name="second">The second function to invoke with the result of the first function.</param>
        /// <returns>A composed function that takes ten inputs of type <typeparamref name="T1"/>, <typeparamref name="T2"/>, <typeparamref name="T3"/>, <typeparamref name="T4"/>, <typeparamref name="T5"/>, <typeparamref name="T6"/>, <typeparamref name="T7"/>, <typeparamref name="T8"/>, <typeparamref name="T9"/>, and <typeparamref name="T10"/> and returns a result of type <typeparamref name="TResult2"/>.</returns>
        /// <exception cref="ArgumentNullException">Thrown if either <paramref name="first"/> or <paramref name="second"/> is null.</exception>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult2> Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult1, TResult2>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult1> first, Func<TResult1, TResult2> second)
        {
            if(first == null) throw new ArgumentNullException(nameof(first));
            if(second == null) throw new ArgumentNullException(nameof(second));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10) => second(first(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10));
        }

        /// <summary>
        /// Composes two functions with eleven input parameters.
        /// </summary>
        /// <typeparam name="T1">The type of the first input parameter for the first function.</typeparam>
        /// <typeparam name="T2">The type of the second input parameter for the first function.</typeparam>
        /// <typeparam name="T3">The type of the third input parameter for the first function.</typeparam>
        /// <typeparam name="T4">The type of the fourth input parameter for the first function.</typeparam>
        /// <typeparam name="T5">The type of the fifth input parameter for the first function.</typeparam>
        /// <typeparam name="T6">The type of the sixth input parameter for the first function.</typeparam>
        /// <typeparam name="T7">The type of the seventh input parameter for the first function.</typeparam>
        /// <typeparam name="T8">The type of the eighth input parameter for the first function.</typeparam>
        /// <typeparam name="T9">The type of the ninth input parameter for the first function.</typeparam>
        /// <typeparam name="T10">The type of the tenth input parameter for the first function.</typeparam>
        /// <typeparam name="T11">The type of the eleventh input parameter for the first function.</typeparam>
        /// <typeparam name="TResult1">The return type of the first function, which is also the input type for the second function.</typeparam>
        /// <typeparam name="TResult2">The return type of the second function.</typeparam>
        /// <param name="first">The first function to invoke.</param>
        /// <param name="second">The second function to invoke with the result of the first function.</param>
        /// <returns>A composed function that takes eleven inputs and returns a result of type <typeparamref name="TResult2"/>.</returns>
        /// <exception cref="ArgumentNullException">Thrown if either <paramref name="first"/> or <paramref name="second"/> is null.</exception>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult2> Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult1, TResult2>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult1> first, Func<TResult1, TResult2> second)
        {
            if(first == null) throw new ArgumentNullException(nameof(first));
            if(second == null) throw new ArgumentNullException(nameof(second));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11) => second(first(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11));
        }

        /// <summary>
        /// Composes two functions with twelve input parameters.
        /// </summary>
        /// <typeparam name="T1">The type of the first input parameter for the first function.</typeparam>
        /// <typeparam name="T2">The type of the second input parameter for the first function.</typeparam>
        /// <typeparam name="T3">The type of the third input parameter for the first function.</typeparam>
        /// <typeparam name="T4">The type of the fourth input parameter for the first function.</typeparam>
        /// <typeparam name="T5">The type of the fifth input parameter for the first function.</typeparam>
        /// <typeparam name="T6">The type of the sixth input parameter for the first function.</typeparam>
        /// <typeparam name="T7">The type of the seventh input parameter for the first function.</typeparam>
        /// <typeparam name="T8">The type of the eighth input parameter for the first function.</typeparam>
        /// <typeparam name="T9">The type of the ninth input parameter for the first function.</typeparam>
        /// <typeparam name="T10">The type of the tenth input parameter for the first function.</typeparam>
        /// <typeparam name="T11">The type of the eleventh input parameter for the first function.</typeparam>
        /// <typeparam name="T12">The type of the twelfth input parameter for the first function.</typeparam>
        /// <typeparam name="TResult1">The return type of the first function, which is also the input type for the second function.</typeparam>
        /// <typeparam name="TResult2">The return type of the second function.</typeparam>
        /// <param name="first">The first function to invoke.</param>
        /// <param name="second">The second function to invoke with the result of the first function.</param>
        /// <returns>A composed function that takes twelve inputs and returns a result of type <typeparamref name="TResult2"/>.</returns>
        /// <exception cref="ArgumentNullException">Thrown if either <paramref name="first"/> or <paramref name="second"/> is null.</exception>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult2> Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult1, TResult2>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult1> first, Func<TResult1, TResult2> second)
        {
            if(first == null) throw new ArgumentNullException(nameof(first));
            if(second == null) throw new ArgumentNullException(nameof(second));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12) => second(first(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12));
        }

        /// <summary>
        /// Composes two functions with thirteen input parameters.
        /// </summary>
        /// <typeparam name="T1">The type of the first input parameter for the first function.</typeparam>
        /// <typeparam name="T2">The type of the second input parameter for the first function.</typeparam>
        /// <typeparam name="T3">The type of the third input parameter for the first function.</typeparam>
        /// <typeparam name="T4">The type of the fourth input parameter for the first function.</typeparam>
        /// <typeparam name="T5">The type of the fifth input parameter for the first function.</typeparam>
        /// <typeparam name="T6">The type of the sixth input parameter for the first function.</typeparam>
        /// <typeparam name="T7">The type of the seventh input parameter for the first function.</typeparam>
        /// <typeparam name="T8">The type of the eighth input parameter for the first function.</typeparam>
        /// <typeparam name="T9">The type of the ninth input parameter for the first function.</typeparam>
        /// <typeparam name="T10">The type of the tenth input parameter for the first function.</typeparam>
        /// <typeparam name="T11">The type of the eleventh input parameter for the first function.</typeparam>
        /// <typeparam name="T12">The type of the twelfth input parameter for the first function.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth input parameter for the first function.</typeparam>
        /// <typeparam name="TResult1">The return type of the first function, which is also the input type for the second function.</typeparam>
        /// <typeparam name="TResult2">The return type of the second function.</typeparam>
        /// <param name="first">The first function to invoke.</param>
        /// <param name="second">The second function to invoke with the result of the first function.</param>
        /// <returns>A composed function that takes thirteen inputs and returns a result of type <typeparamref name="TResult2"/>.</returns>
        /// <exception cref="ArgumentNullException">Thrown if either <paramref name="first"/> or <paramref name="second"/> is null.</exception>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult2> Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult1, TResult2>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult1> first, Func<TResult1, TResult2> second)
        {
            if(first == null) throw new ArgumentNullException(nameof(first));
            if(second == null) throw new ArgumentNullException(nameof(second));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13) => second(first(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13));
        }

        /// <summary>
        /// Composes two functions with fourteen input parameters.
        /// </summary>
        /// <typeparam name="T1">The type of the first input parameter for the first function.</typeparam>
        /// <typeparam name="T2">The type of the second input parameter for the first function.</typeparam>
        /// <typeparam name="T3">The type of the third input parameter for the first function.</typeparam>
        /// <typeparam name="T4">The type of the fourth input parameter for the first function.</typeparam>
        /// <typeparam name="T5">The type of the fifth input parameter for the first function.</typeparam>
        /// <typeparam name="T6">The type of the sixth input parameter for the first function.</typeparam>
        /// <typeparam name="T7">The type of the seventh input parameter for the first function.</typeparam>
        /// <typeparam name="T8">The type of the eighth input parameter for the first function.</typeparam>
        /// <typeparam name="T9">The type of the ninth input parameter for the first function.</typeparam>
        /// <typeparam name="T10">The type of the tenth input parameter for the first function.</typeparam>
        /// <typeparam name="T11">The type of the eleventh input parameter for the first function.</typeparam>
        /// <typeparam name="T12">The type of the twelfth input parameter for the first function.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth input parameter for the first function.</typeparam>
        /// <typeparam name="T14">The type of the fourteenth input parameter for the first function.</typeparam>
        /// <typeparam name="TResult1">The return type of the first function, which is also the input type for the second function.</typeparam>
        /// <typeparam name="TResult2">The return type of the second function.</typeparam>
        /// <param name="first">The first function to invoke.</param>
        /// <param name="second">The second function to invoke with the result of the first function.</param>
        /// <returns>A composed function that takes fourteen inputs and returns a result of type <typeparamref name="TResult2"/>.</returns>
        /// <exception cref="ArgumentNullException">Thrown if either <paramref name="first"/> or <paramref name="second"/> is null.</exception>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult2> Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult1, TResult2>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult1> first, Func<TResult1, TResult2> second)
        {
            if(first == null) throw new ArgumentNullException(nameof(first));
            if(second == null) throw new ArgumentNullException(nameof(second));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14) => second(first(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14));
        }

        /// <summary>
        /// Composes two functions with fifteen input parameters.
        /// </summary>
        /// <typeparam name="T1">The type of the first input parameter for the first function.</typeparam>
        /// <typeparam name="T2">The type of the second input parameter for the first function.</typeparam>
        /// <typeparam name="T3">The type of the third input parameter for the first function.</typeparam>
        /// <typeparam name="T4">The type of the fourth input parameter for the first function.</typeparam>
        /// <typeparam name="T5">The type of the fifth input parameter for the first function.</typeparam>
        /// <typeparam name="T6">The type of the sixth input parameter for the first function.</typeparam>
        /// <typeparam name="T7">The type of the seventh input parameter for the first function.</typeparam>
        /// <typeparam name="T8">The type of the eighth input parameter for the first function.</typeparam>
        /// <typeparam name="T9">The type of the ninth input parameter for the first function.</typeparam>
        /// <typeparam name="T10">The type of the tenth input parameter for the first function.</typeparam>
        /// <typeparam name="T11">The type of the eleventh input parameter for the first function.</typeparam>
        /// <typeparam name="T12">The type of the twelfth input parameter for the first function.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth input parameter for the first function.</typeparam>
        /// <typeparam name="T14">The type of the fourteenth input parameter for the first function.</typeparam>
        /// <typeparam name="T15">The type of the fifteenth input parameter for the first function.</typeparam>
        /// <typeparam name="TResult1">The return type of the first function, which is also the input type for the second function.</typeparam>
        /// <typeparam name="TResult2">The return type of the second function.</typeparam>
        /// <param name="first">The first function to invoke.</param>
        /// <param name="second">The second function to invoke with the result of the first function.</param>
        /// <returns>A composed function that takes fifteen inputs and returns a result of type <typeparamref name="TResult2"/>.</returns>
        /// <exception cref="ArgumentNullException">Thrown if either <paramref name="first"/> or <paramref name="second"/> is null.</exception>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult2> Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult1, TResult2>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult1> first, Func<TResult1, TResult2> second)
        {
            if(first == null) throw new ArgumentNullException(nameof(first));
            if(second == null) throw new ArgumentNullException(nameof(second));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15) => second(first(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15));
        }

        /// <summary>
        /// Composes two functions with sixteen input parameters.
        /// </summary>
        /// <typeparam name="T1">The type of the first input parameter for the first function.</typeparam>
        /// <typeparam name="T2">The type of the second input parameter for the first function.</typeparam>
        /// <typeparam name="T3">The type of the third input parameter for the first function.</typeparam>
        /// <typeparam name="T4">The type of the fourth input parameter for the first function.</typeparam>
        /// <typeparam name="T5">The type of the fifth input parameter for the first function.</typeparam>
        /// <typeparam name="T6">The type of the sixth input parameter for the first function.</typeparam>
        /// <typeparam name="T7">The type of the seventh input parameter for the first function.</typeparam>
        /// <typeparam name="T8">The type of the eighth input parameter for the first function.</typeparam>
        /// <typeparam name="T9">The type of the ninth input parameter for the first function.</typeparam>
        /// <typeparam name="T10">The type of the tenth input parameter for the first function.</typeparam>
        /// <typeparam name="T11">The type of the eleventh input parameter for the first function.</typeparam>
        /// <typeparam name="T12">The type of the twelfth input parameter for the first function.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth input parameter for the first function.</typeparam>
        /// <typeparam name="T14">The type of the fourteenth input parameter for the first function.</typeparam>
        /// <typeparam name="T15">The type of the fifteenth input parameter for the first function.</typeparam>
        /// <typeparam name="T16">The type of the sixteenth input parameter for the first function.</typeparam>
        /// <typeparam name="TResult1">The return type of the first function, which is also the input type for the second function.</typeparam>
        /// <typeparam name="TResult2">The return type of the second function.</typeparam>
        /// <param name="first">The first function to invoke.</param>
        /// <param name="second">The second function to invoke with the result of the first function.</param>
        /// <returns>A composed function that takes sixteen inputs and returns a result of type <typeparamref name="TResult2"/>.</returns>
        /// <exception cref="ArgumentNullException">Thrown if either <paramref name="first"/> or <paramref name="second"/> is null.</exception>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult2> Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult1, TResult2>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult1> first, Func<TResult1, TResult2> second)
        {
            if(first == null) throw new ArgumentNullException(nameof(first));
            if(second == null) throw new ArgumentNullException(nameof(second));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16) => second(first(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16));
        }
    }
}
