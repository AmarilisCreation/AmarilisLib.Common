using System;

namespace AmarilisLib
{
    /// <summary>
    /// Provides extension methods for composing multiple <see cref="Action"/> delegates.
    /// </summary>
    public static class ActionExtensions
    {
        /// <summary>
        /// Composes two <see cref="Action"/> delegates into one, where both actions are invoked sequentially.
        /// </summary>
        /// <param name="first">The first action to invoke.</param>
        /// <param name="second">The second action to invoke after the first.</param>
        /// <returns>A composed action that invokes both actions in sequence.</returns>
        /// <exception cref="ArgumentNullException">Thrown if either <paramref name="first"/> or <paramref name="second"/> is null.</exception>
        public static Action Compose(this Action first, Action second)
        {
            if(first == null) throw new ArgumentNullException(nameof(first));
            if(second == null) throw new ArgumentNullException(nameof(second));
            return () => { first(); second(); };
        }

        /// <summary>
        /// Composes two <see cref="Action{T}"/> delegates into one, where both actions are invoked sequentially with the same argument.
        /// </summary>
        /// <typeparam name="T">The type of the argument passed to the actions.</typeparam>
        /// <param name="first">The first action to invoke.</param>
        /// <param name="second">The second action to invoke after the first.</param>
        /// <returns>A composed action that invokes both actions in sequence with the same argument.</returns>
        /// <exception cref="ArgumentNullException">Thrown if either <paramref name="first"/> or <paramref name="second"/> is null.</exception>
        public static Action<T> Compose<T>(this Action<T> first, Action<T> second)
        {
            if(first == null) throw new ArgumentNullException(nameof(first));
            if(second == null) throw new ArgumentNullException(nameof(second));
            return (arg) => { first(arg); second(arg); };
        }

        /// <summary>
        /// Composes two <see cref="Action{T1, T2}"/> delegates into one, where both actions are invoked sequentially with the same arguments.
        /// </summary>
        /// <typeparam name="T1">The type of the first argument.</typeparam>
        /// <typeparam name="T2">The type of the second argument.</typeparam>
        /// <param name="first">The first action to invoke.</param>
        /// <param name="second">The second action to invoke after the first.</param>
        /// <returns>A composed action that invokes both actions in sequence with the same arguments.</returns>
        /// <exception cref="ArgumentNullException">Thrown if either <paramref name="first"/> or <paramref name="second"/> is null.</exception>
        public static Action<T1, T2> Compose<T1, T2>(this Action<T1, T2> first, Action<T1, T2> second)
        {
            if(first == null) throw new ArgumentNullException(nameof(first));
            if(second == null) throw new ArgumentNullException(nameof(second));
            return (arg1, arg2) => { first(arg1, arg2); second(arg1, arg2); };
        }

        /// <summary>
        /// Composes two <see cref="Action{T1, T2, T3}"/> delegates into one, where both actions are invoked sequentially with the same arguments.
        /// </summary>
        /// <typeparam name="T1">The type of the first argument.</typeparam>
        /// <typeparam name="T2">The type of the second argument.</typeparam>
        /// <typeparam name="T3">The type of the third argument.</typeparam>
        /// <param name="first">The first action to invoke.</param>
        /// <param name="second">The second action to invoke after the first.</param>
        /// <returns>A composed action that invokes both actions in sequence with the same arguments.</returns>
        /// <exception cref="ArgumentNullException">Thrown if either <paramref name="first"/> or <paramref name="second"/> is null.</exception>
        public static Action<T1, T2, T3> Compose<T1, T2, T3>(this Action<T1, T2, T3> first, Action<T1, T2, T3> second)
        {
            if(first == null) throw new ArgumentNullException(nameof(first));
            if(second == null) throw new ArgumentNullException(nameof(second));
            return (arg1, arg2, arg3) => { first(arg1, arg2, arg3); second(arg1, arg2, arg3); };
        }

        /// <summary>
        /// Composes two <see cref="Action{T1, T2, T3, T4}"/> delegates into one, where both actions are invoked sequentially with the same arguments.
        /// </summary>
        /// <typeparam name="T1">The type of the first argument.</typeparam>
        /// <typeparam name="T2">The type of the second argument.</typeparam>
        /// <typeparam name="T3">The type of the third argument.</typeparam>
        /// <typeparam name="T4">The type of the fourth argument.</typeparam>
        /// <param name="first">The first action to invoke.</param>
        /// <param name="second">The second action to invoke after the first.</param>
        /// <returns>A composed action that invokes both actions in sequence with the same arguments.</returns>
        /// <exception cref="ArgumentNullException">Thrown if either <paramref name="first"/> or <paramref name="second"/> is null.</exception>
        public static Action<T1, T2, T3, T4> Compose<T1, T2, T3, T4>(this Action<T1, T2, T3, T4> first, Action<T1, T2, T3, T4> second)
        {
            if(first == null) throw new ArgumentNullException(nameof(first));
            if(second == null) throw new ArgumentNullException(nameof(second));
            return (arg1, arg2, arg3, arg4) => { first(arg1, arg2, arg3, arg4); second(arg1, arg2, arg3, arg4); };
        }

        /// <summary>
        /// Composes two <see cref="Action{T1, T2, T3, T4, T5}"/> delegates into one, where both actions are invoked sequentially with the same arguments.
        /// </summary>
        /// <typeparam name="T1">The type of the first argument.</typeparam>
        /// <typeparam name="T2">The type of the second argument.</typeparam>
        /// <typeparam name="T3">The type of the third argument.</typeparam>
        /// <typeparam name="T4">The type of the fourth argument.</typeparam>
        /// <typeparam name="T5">The type of the fifth argument.</typeparam>
        /// <param name="first">The first action to invoke.</param>
        /// <param name="second">The second action to invoke after the first.</param>
        /// <returns>A composed action that invokes both actions in sequence with the same arguments.</returns>
        /// <exception cref="ArgumentNullException">Thrown if either <paramref name="first"/> or <paramref name="second"/> is null.</exception>
        public static Action<T1, T2, T3, T4, T5> Compose<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> first, Action<T1, T2, T3, T4, T5> second)
        {
            if(first == null) throw new ArgumentNullException(nameof(first));
            if(second == null) throw new ArgumentNullException(nameof(second));
            return (arg1, arg2, arg3, arg4, arg5) => { first(arg1, arg2, arg3, arg4, arg5); second(arg1, arg2, arg3, arg4, arg5); };
        }

        /// <summary>
        /// Composes two <see cref="Action{T1, T2, T3, T4, T5, T6}"/> delegates into one, where both actions are invoked sequentially with the same arguments.
        /// </summary>
        /// <typeparam name="T1">The type of the first argument.</typeparam>
        /// <typeparam name="T2">The type of the second argument.</typeparam>
        /// <typeparam name="T3">The type of the third argument.</typeparam>
        /// <typeparam name="T4">The type of the fourth argument.</typeparam>
        /// <typeparam name="T5">The type of the fifth argument.</typeparam>
        /// <typeparam name="T6">The type of the sixth argument.</typeparam>
        /// <param name="first">The first action to invoke.</param>
        /// <param name="second">The second action to invoke after the first.</param>
        /// <returns>A composed action that invokes both actions in sequence with the same arguments.</returns>
        /// <exception cref="ArgumentNullException">Thrown if either <paramref name="first"/> or <paramref name="second"/> is null.</exception>
        public static Action<T1, T2, T3, T4, T5, T6> Compose<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> first, Action<T1, T2, T3, T4, T5, T6> second)
        {
            if(first == null) throw new ArgumentNullException(nameof(first));
            if(second == null) throw new ArgumentNullException(nameof(second));
            return (arg1, arg2, arg3, arg4, arg5, arg6) => { first(arg1, arg2, arg3, arg4, arg5, arg6); second(arg1, arg2, arg3, arg4, arg5, arg6); };
        }

        /// <summary>
        /// Composes two <see cref="Action{T1, T2, T3, T4, T5, T6, T7}"/> delegates into one, where both actions are invoked sequentially with the same arguments.
        /// </summary>
        /// <typeparam name="T1">The type of the first argument.</typeparam>
        /// <typeparam name="T2">The type of the second argument.</typeparam>
        /// <typeparam name="T3">The type of the third argument.</typeparam>
        /// <typeparam name="T4">The type of the fourth argument.</typeparam>
        /// <typeparam name="T5">The type of the fifth argument.</typeparam>
        /// <typeparam name="T6">The type of the sixth argument.</typeparam>
        /// <typeparam name="T7">The type of the seventh argument.</typeparam>
        /// <param name="first">The first action to invoke.</param>
        /// <param name="second">The second action to invoke after the first.</param>
        /// <returns>A composed action that invokes both actions in sequence with the same arguments.</returns>
        /// <exception cref="ArgumentNullException">Thrown if either <paramref name="first"/> or <paramref name="second"/> is null.</exception>
        public static Action<T1, T2, T3, T4, T5, T6, T7> Compose<T1, T2, T3, T4, T5, T6, T7>(this Action<T1, T2, T3, T4, T5, T6, T7> first, Action<T1, T2, T3, T4, T5, T6, T7> second)
        {
            if(first == null) throw new ArgumentNullException(nameof(first));
            if(second == null) throw new ArgumentNullException(nameof(second));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7) => { first(arg1, arg2, arg3, arg4, arg5, arg6, arg7); second(arg1, arg2, arg3, arg4, arg5, arg6, arg7); };
        }

        /// <summary>
        /// Composes two <see cref="Action{T1, T2, T3, T4, T5, T6, T7, T8}"/> delegates into one, where both actions are invoked sequentially with the same arguments.
        /// </summary>
        /// <typeparam name="T1">The type of the first argument.</typeparam>
        /// <typeparam name="T2">The type of the second argument.</typeparam>
        /// <typeparam name="T3">The type of the third argument.</typeparam>
        /// <typeparam name="T4">The type of the fourth argument.</typeparam>
        /// <typeparam name="T5">The type of the fifth argument.</typeparam>
        /// <typeparam name="T6">The type of the sixth argument.</typeparam>
        /// <typeparam name="T7">The type of the seventh argument.</typeparam>
        /// <typeparam name="T8">The type of the eighth argument.</typeparam>
        /// <param name="first">The first action to invoke.</param>
        /// <param name="second">The second action to invoke after the first.</param>
        /// <returns>A composed action that invokes both actions in sequence with the same arguments.</returns>
        /// <exception cref="ArgumentNullException">Thrown if either <paramref name="first"/> or <paramref name="second"/> is null.</exception>
        public static Action<T1, T2, T3, T4, T5, T6, T7, T8> Compose<T1, T2, T3, T4, T5, T6, T7, T8>(this Action<T1, T2, T3, T4, T5, T6, T7, T8> first, Action<T1, T2, T3, T4, T5, T6, T7, T8> second)
        {
            if(first == null) throw new ArgumentNullException(nameof(first));
            if(second == null) throw new ArgumentNullException(nameof(second));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8) => { first(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8); second(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8); };
        }

        /// <summary>
        /// Composes two <see cref="Action{T1, T2, T3, T4, T5, T6, T7, T8, T9}"/> delegates into one, where both actions are invoked sequentially with the same arguments.
        /// </summary>
        /// <typeparam name="T1">The type of the first argument.</typeparam>
        /// <typeparam name="T2">The type of the second argument.</typeparam>
        /// <typeparam name="T3">The type of the third argument.</typeparam>
        /// <typeparam name="T4">The type of the fourth argument.</typeparam>
        /// <typeparam name="T5">The type of the fifth argument.</typeparam>
        /// <typeparam name="T6">The type of the sixth argument.</typeparam>
        /// <typeparam name="T7">The type of the seventh argument.</typeparam>
        /// <typeparam name="T8">The type of the eighth argument.</typeparam>
        /// <typeparam name="T9">The type of the ninth argument.</typeparam>
        /// <param name="first">The first action to invoke.</param>
        /// <param name="second">The second action to invoke after the first.</param>
        /// <returns>A composed action that invokes both actions in sequence with the same arguments.</returns>
        /// <exception cref="ArgumentNullException">Thrown if either <paramref name="first"/> or <paramref name="second"/> is null.</exception>
        public static Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> first, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> second)
        {
            if(first == null) throw new ArgumentNullException(nameof(first));
            if(second == null) throw new ArgumentNullException(nameof(second));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9) => { first(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9); second(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9); };
        }

        /// <summary>
        /// Composes two <see cref="Action{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}"/> delegates into one, where both actions are invoked sequentially with the same arguments.
        /// </summary>
        /// <typeparam name="T1">The type of the first argument.</typeparam>
        /// <typeparam name="T2">The type of the second argument.</typeparam>
        /// <typeparam name="T3">The type of the third argument.</typeparam>
        /// <typeparam name="T4">The type of the fourth argument.</typeparam>
        /// <typeparam name="T5">The type of the fifth argument.</typeparam>
        /// <typeparam name="T6">The type of the sixth argument.</typeparam>
        /// <typeparam name="T7">The type of the seventh argument.</typeparam>
        /// <typeparam name="T8">The type of the eighth argument.</typeparam>
        /// <typeparam name="T9">The type of the ninth argument.</typeparam>
        /// <typeparam name="T10">The type of the tenth argument.</typeparam>
        /// <param name="first">The first action to invoke.</param>
        /// <param name="second">The second action to invoke after the first.</param>
        /// <returns>A composed action that invokes both actions in sequence with the same arguments.</returns>
        /// <exception cref="ArgumentNullException">Thrown if either <paramref name="first"/> or <paramref name="second"/> is null.</exception>
        public static Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> first, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> second)
        {
            if(first == null) throw new ArgumentNullException(nameof(first));
            if(second == null) throw new ArgumentNullException(nameof(second));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10) => { first(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10); second(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10); };
        }

        /// <summary>
        /// Composes two <see cref="Action{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}"/> delegates into one, where both actions are invoked sequentially with the same arguments.
        /// </summary>
        /// <typeparam name="T1">The type of the first argument.</typeparam>
        /// <typeparam name="T2">The type of the second argument.</typeparam>
        /// <typeparam name="T3">The type of the third argument.</typeparam>
        /// <typeparam name="T4">The type of the fourth argument.</typeparam>
        /// <typeparam name="T5">The type of the fifth argument.</typeparam>
        /// <typeparam name="T6">The type of the sixth argument.</typeparam>
        /// <typeparam name="T7">The type of the seventh argument.</typeparam>
        /// <typeparam name="T8">The type of the eighth argument.</typeparam>
        /// <typeparam name="T9">The type of the ninth argument.</typeparam>
        /// <typeparam name="T10">The type of the tenth argument.</typeparam>
        /// <typeparam name="T11">The type of the eleventh argument.</typeparam>
        /// <param name="first">The first action to invoke.</param>
        /// <param name="second">The second action to invoke after the first.</param>
        /// <returns>A composed action that invokes both actions in sequence with the same arguments.</returns>
        /// <exception cref="ArgumentNullException">Thrown if either <paramref name="first"/> or <paramref name="second"/> is null.</exception>
        public static Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> first, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> second)
        {
            if(first == null) throw new ArgumentNullException(nameof(first));
            if(second == null) throw new ArgumentNullException(nameof(second));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11) => { first(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11); second(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11); };
        }

        /// <summary>
        /// Composes two <see cref="Action{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}"/> delegates into one, where both actions are invoked sequentially with the same arguments.
        /// </summary>
        /// <typeparam name="T1">The type of the first argument.</typeparam>
        /// <typeparam name="T2">The type of the second argument.</typeparam>
        /// <typeparam name="T3">The type of the third argument.</typeparam>
        /// <typeparam name="T4">The type of the fourth argument.</typeparam>
        /// <typeparam name="T5">The type of the fifth argument.</typeparam>
        /// <typeparam name="T6">The type of the sixth argument.</typeparam>
        /// <typeparam name="T7">The type of the seventh argument.</typeparam>
        /// <typeparam name="T8">The type of the eighth argument.</typeparam>
        /// <typeparam name="T9">The type of the ninth argument.</typeparam>
        /// <typeparam name="T10">The type of the tenth argument.</typeparam>
        /// <typeparam name="T11">The type of the eleventh argument.</typeparam>
        /// <typeparam name="T12">The type of the twelfth argument.</typeparam>
        /// <param name="first">The first action to invoke.</param>
        /// <param name="second">The second action to invoke after the first.</param>
        /// <returns>A composed action that invokes both actions in sequence with the same arguments.</returns>
        /// <exception cref="ArgumentNullException">Thrown if either <paramref name="first"/> or <paramref name="second"/> is null.</exception>
        public static Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> first, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> second)
        {
            if(first == null) throw new ArgumentNullException(nameof(first));
            if(second == null) throw new ArgumentNullException(nameof(second));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12) => { first(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12); second(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12); };
        }

        /// <summary>
        /// Composes two <see cref="Action{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}"/> delegates into one, where both actions are invoked sequentially with the same arguments.
        /// </summary>
        /// <typeparam name="T1">The type of the first argument.</typeparam>
        /// <typeparam name="T2">The type of the second argument.</typeparam>
        /// <typeparam name="T3">The type of the third argument.</typeparam>
        /// <typeparam name="T4">The type of the fourth argument.</typeparam>
        /// <typeparam name="T5">The type of the fifth argument.</typeparam>
        /// <typeparam name="T6">The type of the sixth argument.</typeparam>
        /// <typeparam name="T7">The type of the seventh argument.</typeparam>
        /// <typeparam name="T8">The type of the eighth argument.</typeparam>
        /// <typeparam name="T9">The type of the ninth argument.</typeparam>
        /// <typeparam name="T10">The type of the tenth argument.</typeparam>
        /// <typeparam name="T11">The type of the eleventh argument.</typeparam>
        /// <typeparam name="T12">The type of the twelfth argument.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth argument.</typeparam>
        /// <param name="first">The first action to invoke.</param>
        /// <param name="second">The second action to invoke after the first.</param>
        /// <returns>A composed action that invokes both actions in sequence with the same arguments.</returns>
        /// <exception cref="ArgumentNullException">Thrown if either <paramref name="first"/> or <paramref name="second"/> is null.</exception>
        public static Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> first, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> second)
        {
            if(first == null) throw new ArgumentNullException(nameof(first));
            if(second == null) throw new ArgumentNullException(nameof(second));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13) =>
            {
                first(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
                second(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
            };
        }

        /// <summary>
        /// Composes two <see cref="Action{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}"/> delegates into one, where both actions are invoked sequentially with the same arguments.
        /// </summary>
        /// <typeparam name="T1">The type of the first argument.</typeparam>
        /// <typeparam name="T2">The type of the second argument.</typeparam>
        /// <typeparam name="T3">The type of the third argument.</typeparam>
        /// <typeparam name="T4">The type of the fourth argument.</typeparam>
        /// <typeparam name="T5">The type of the fifth argument.</typeparam>
        /// <typeparam name="T6">The type of the sixth argument.</typeparam>
        /// <typeparam name="T7">The type of the seventh argument.</typeparam>
        /// <typeparam name="T8">The type of the eighth argument.</typeparam>
        /// <typeparam name="T9">The type of the ninth argument.</typeparam>
        /// <typeparam name="T10">The type of the tenth argument.</typeparam>
        /// <typeparam name="T11">The type of the eleventh argument.</typeparam>
        /// <typeparam name="T12">The type of the twelfth argument.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth argument.</typeparam>
        /// <typeparam name="T14">The type of the fourteenth argument.</typeparam>
        /// <param name="first">The first action to invoke.</param>
        /// <param name="second">The second action to invoke after the first.</param>
        /// <returns>A composed action that invokes both actions in sequence with the same arguments.</returns>
        /// <exception cref="ArgumentNullException">Thrown if either <paramref name="first"/> or <paramref name="second"/> is null.</exception>
        public static Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> first, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> second)
        {
            if(first == null) throw new ArgumentNullException(nameof(first));
            if(second == null) throw new ArgumentNullException(nameof(second));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14) =>
            {
                first(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
                second(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
            };
        }

        /// <summary>
        /// Composes two <see cref="Action{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15}"/> delegates into one, where both actions are invoked sequentially with the same arguments.
        /// </summary>
        /// <typeparam name="T1">The type of the first argument.</typeparam>
        /// <typeparam name="T2">The type of the second argument.</typeparam>
        /// <typeparam name="T3">The type of the third argument.</typeparam>
        /// <typeparam name="T4">The type of the fourth argument.</typeparam>
        /// <typeparam name="T5">The type of the fifth argument.</typeparam>
        /// <typeparam name="T6">The type of the sixth argument.</typeparam>
        /// <typeparam name="T7">The type of the seventh argument.</typeparam>
        /// <typeparam name="T8">The type of the eighth argument.</typeparam>
        /// <typeparam name="T9">The type of the ninth argument.</typeparam>
        /// <typeparam name="T10">The type of the tenth argument.</typeparam>
        /// <typeparam name="T11">The type of the eleventh argument.</typeparam>
        /// <typeparam name="T12">The type of the twelfth argument.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth argument.</typeparam>
        /// <typeparam name="T14">The type of the fourteenth argument.</typeparam>
        /// <typeparam name="T15">The type of the fifteenth argument.</typeparam>
        /// <param name="first">The first action to invoke.</param>
        /// <param name="second">The second action to invoke after the first.</param>
        /// <returns>A composed action that invokes both actions in sequence with the same arguments.</returns>
        /// <exception cref="ArgumentNullException">Thrown if either <paramref name="first"/> or <paramref name="second"/> is null.</exception>
        public static Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> first, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> second)
        {
            if(first == null) throw new ArgumentNullException(nameof(first));
            if(second == null) throw new ArgumentNullException(nameof(second));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15) =>
            {
                first(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
                second(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
            };
        }

        /// <summary>
        /// Composes two <see cref="Action{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16}"/> delegates into one, where both actions are invoked sequentially with the same arguments.
        /// </summary>
        /// <typeparam name="T1">The type of the first argument.</typeparam>
        /// <typeparam name="T2">The type of the second argument.</typeparam>
        /// <typeparam name="T3">The type of the third argument.</typeparam>
        /// <typeparam name="T4">The type of the fourth argument.</typeparam>
        /// <typeparam name="T5">The type of the fifth argument.</typeparam>
        /// <typeparam name="T6">The type of the sixth argument.</typeparam>
        /// <typeparam name="T7">The type of the seventh argument.</typeparam>
        /// <typeparam name="T8">The type of the eighth argument.</typeparam>
        /// <typeparam name="T9">The type of the ninth argument.</typeparam>
        /// <typeparam name="T10">The type of the tenth argument.</typeparam>
        /// <typeparam name="T11">The type of the eleventh argument.</typeparam>
        /// <typeparam name="T12">The type of the twelfth argument.</typeparam>
        /// <typeparam name="T13">The type of the thirteenth argument.</typeparam>
        /// <typeparam name="T14">The type of the fourteenth argument.</typeparam>
        /// <typeparam name="T15">The type of the fifteenth argument.</typeparam>
        /// <typeparam name="T16">The type of the sixteenth argument.</typeparam>
        /// <param name="first">The first action to invoke.</param>
        /// <param name="second">The second action to invoke after the first.</param>
        /// <returns>A composed action that invokes both actions in sequence with the same arguments.</returns>
        /// <exception cref="ArgumentNullException">Thrown if either <paramref name="first"/> or <paramref name="second"/> is null.</exception>
        public static Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> first, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> second)
        {
            if(first == null) throw new ArgumentNullException(nameof(first));
            if(second == null) throw new ArgumentNullException(nameof(second));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16) =>
            {
                first(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
                second(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
            };
        }
    }
}
