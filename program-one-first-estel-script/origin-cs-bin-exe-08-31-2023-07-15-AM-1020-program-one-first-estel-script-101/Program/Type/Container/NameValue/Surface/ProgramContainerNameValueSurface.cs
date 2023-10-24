using Core;

namespace Core
{
    using System;

    using System.Linq;

    using System.Collections;

    internal partial class Program
    {
        internal static T[] ProgramNameValueContainerSurface<T>()
        {
            T[] arrayResult = default;

            var list = ProgramNameValueContainer();

            IEnumerable enumerable;

            enumerable = list.OfType<T>().Cast<T>().ToArray();

            var reflect = (T[])(enumerable as Array);

            T[] array;

            array = reflect;

            arrayResult = array;

            return arrayResult;
        }
    }
}
